using Ares.BusinessManager.Interfaces;
using Ares.Core.Domain;
using Ares.Core.Dto;
using Ares.Core.Repositories;
using System;
using System.Collections.Generic;

namespace Ares.BusinessManager.Implementation
{
    public class TransactionManager : ITransactionManager
    {
        private ITransactionRepository _transactionRepository;
        private ITransInfoDetailRepository _transactionDetailInfoRepository;
        private ITransactionRatingRepository _transRatingRepository;

        public TransactionManager(ITransactionRepository transactionRepository,ITransInfoDetailRepository transactionInfoDetailRespository,ITransactionRatingRepository transRatingRepository)
        {
            _transactionRepository = transactionRepository;
            _transactionDetailInfoRepository = transactionInfoDetailRespository;
            _transRatingRepository = transRatingRepository;
        }


        public IEnumerable<Transaction> FindTopTransactionByUser(int employeeId)
        {
            return _transactionRepository.FindAll(e => e.EmployeeId == employeeId && e.TransactionDateTime >= DateTime.Now.AddDays(-DateTime.Now.Day), "TransactionDateTime", 0, 5);
        }

        public IEnumerable<Transaction> FindTransactionsHistory(int employeeId, int pageIndex, int pageSize)
        {
            return _transactionRepository.FindAll(e => e.EmployeeId == employeeId, "TransactionDateTime", pageIndex, pageSize);
        }

        public IEnumerable<Transaction> FindTransactionsHistoryByCustomer(int customerId, int pageIndex, int pageSize)
        {
            return _transactionRepository.FindAll(e => e.CustomerId == customerId, "TransactionDateTime", pageIndex, pageSize);
        }

        public CountTransactionByEmpIdReturnModel FindEmployeeTransactionSummary(int employeeId)
        {
            return _transactionRepository.FindEmployeeTransactionSummary(employeeId);
        }

        public decimal CalculateDiscount(int? employeeId, int? customerId, decimal? totalAmount,out int? transactionId)
        {
            decimal? realPay = 0;
            transactionId = 0;
              var result = _transactionRepository.CalculateDiscount(employeeId, customerId, totalAmount, out realPay,out transactionId);
            return realPay.HasValue ? realPay.Value: totalAmount.Value;

        }

        public System.Collections.Generic.List<CheckTransactionByCustomerIdReturnModel> CheckTransactionByCustomerId(int? customerId)
        {
            int procResult = 0;
            return _transactionRepository.CheckTransactionByCustomerId(customerId, out procResult);
        }

        public List<SettlementForCustomerReturnModel> SettlementForCustomer(DateTime? startDate, DateTime? endDate)
        {
            int procResult = 0;

            return _transactionRepository.SettlementForCustomer(startDate, endDate, out procResult);
        }


        public IEnumerable<TransInfoDetail> GetTransInfoDetailByCusId(int customerId)
        {
            return _transactionDetailInfoRepository.FindAll(c => c.CustomerId == customerId);
        }

        public IEnumerable<TransInfoDetail> GetTransInfoDetailByEmployeeId(int employeeId)
        {
            return _transactionDetailInfoRepository.FindAll(c => c.EmployeeId == employeeId);
        }

        public void SubmitComment(TransactionRating comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException("comment");
            }
            _transRatingRepository.Add(comment);
        }

        public void SetTransSucess(int transactionId)
        {
            var transaction = _transactionRepository.FindBy(transactionId);
            transaction.IsSuccessful = true;
            _transactionRepository.Save(transaction);
        }
    }
}
