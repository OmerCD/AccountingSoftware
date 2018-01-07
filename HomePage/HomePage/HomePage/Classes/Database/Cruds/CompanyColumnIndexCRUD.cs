using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <param name="company"></param>
        /// <returns>A Dictionary contains ColumnId as Key and Answer Index as value</returns>
        public List<Tuple<string, int>> GetCompanyAnswerIndexes(Company company)
        {
            var filter = new BsonDocument { { "Company._id", company._id }, { "IsDeleted", 0 } };
            var cCIndexesCursor = Table.FindSync<CompanyColumnIndex>(filter);
            cCIndexesCursor.MoveNext();
            var cCIndexes = cCIndexesCursor.Current;
            var companyColumnIndices = cCIndexes as CompanyColumnIndex[] ?? cCIndexes.ToArray();
            return companyColumnIndices.Select(index => new Tuple<string, int>(index.Column._id, index.AnswerIndex)).ToList();
        }


    }
}
