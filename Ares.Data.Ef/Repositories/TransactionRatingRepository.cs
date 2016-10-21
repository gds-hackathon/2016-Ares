using System;
using Ares.Core.Domain;
using Ares.Core.Dto;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ares.Data.Ef.Repositories
{
    public class TransactionRatingRepository:Repository<TransactionRating,int>,ITransactionRatingRepository
    {
        public TransactionRatingRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }
    }
}
