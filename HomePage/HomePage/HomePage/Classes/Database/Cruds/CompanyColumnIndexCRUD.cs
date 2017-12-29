﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomePage.Document;
using HomePage.Classes.Database.Entities;
using MongoDB.Bson;

namespace HomePage.Classes.Database.Cruds
{
    public class CompanyColumnIndexCRUD : CRUD<CompanyColumnIndex>
    {
        public CompanyColumnIndexCRUD() : base(DbFactory.CompanyColumnIndex)
        {

        }
        /// <summary>
        /// Get information about Company and its Answers to the columns if they exists
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns>A Dictionary contains ColumnId as Key and Answer Index as value</returns>
        public Dictionary<string, int> GetCompanyAnswerIndexes(string companyId) // todo not tested
        {
            var filter = new BsonDocument { { "_id", companyId }, { "IsDeleted", 0 } };
            var cCIndexesCursor = Table.FindSync<CompanyColumnIndex>(filter);
            cCIndexesCursor.MoveNext();
            var cCIndexes = cCIndexesCursor.Current;
            var indexes = new Dictionary<string,int>();
            var companyColumnIndices = cCIndexes as CompanyColumnIndex[] ?? cCIndexes.ToArray();
            foreach (CompanyColumnIndex index in companyColumnIndices)
            {
                indexes.Add(index.Column._id,index.AnswerIndex);
            }
            return indexes;
        }
    }
}