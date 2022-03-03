using Imputations.Application.BusinessModel.Models;
using Imputations.Application.BusinessModel.Responses;
using Imputations.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application.Contracts.Mappers
{
    public static class ImputationMapper
    {
        public static List<ImputationModel> toListImputationModel(this List<Imputation> imputations)
        {
            List<ImputationModel> imputationModelList = new List<ImputationModel>();
            foreach (var item in imputations)
            {
                imputationModelList.Add(item.toImputationModel());
            }
            return imputationModelList;

        }

        public static ImputationModel toImputationModel(this Imputation imputation)
        {
            return new ImputationModel()
            {
                Day = imputation.Day,
                State = imputation.State,
                Extra_Hours = imputation.Extra_Hours,
                Employee_Id = imputation.Employee_Id,
                Imputation_Id = imputation.Imputation_Id,
                Hours = imputation.Hours,
                Project_Id = imputation.Project_Id,
                Week = imputation.Week,
            };
        }

        public static ImputationResponse toImputationsResponse(this ImputationModel imputation)
        {
            return new ImputationResponse()
            {
                Day = imputation.Day,
                State = imputation.State,
                Extra_Hours = imputation.Extra_Hours,
                Employee_Id = imputation.Employee_Id,
                Imputation_Id = imputation.Imputation_Id,
                Hours = imputation.Hours,
                Project_Id = imputation.Project_Id,
                Week = imputation.Week,

            };
        }
    }
}
