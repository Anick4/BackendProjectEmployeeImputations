using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.Contracts.Mappers
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

        public static List<ImputationResponse> toImputationsResponse(this List<ImputationModel> imputationList)
        {
           List<ImputationResponse> imputationResponses = new List<ImputationResponse>();

            var projectIds = imputationList.Select(x => x.Project_Id).Distinct().ToList();
            foreach(var item in projectIds)
            {
               
               ImputationResponse imputationResponse = new ImputationResponse();
                 // Necesito comprobar que no se repita el id del proyecto
                
               imputationResponse.ProjectName = "nombre";
               imputationResponse.ProjectId = item;

                
               imputationResponse.Imputations = imputationList.Where(x => x.Project_Id == item).OrderBy(x => x.Day).ToList().toImputationResponse();
                //INTENTAR ORDENARLO  POR ID
               imputationResponses.Add(imputationResponse);
            }
            imputationResponses = imputationResponses.OrderBy(x => x.ProjectId).ToList();

            return imputationResponses;
        }

        
        //AQUI SACO LA RESPONSE BUENA
        public static List<ImputationResponseBase> toImputationResponse(this List<ImputationModel> imputationModelList)
        {
            List<ImputationResponseBase> imputationResponses = new List<ImputationResponseBase>();
            foreach(var item in imputationModelList)
            {
                
                imputationResponses.Add(new ImputationResponseBase
                {
                    Day = item.Day,
                    Extra_Hours = item.Extra_Hours,
                    Hours = item.Hours,
                    Imputation_Id = item.Imputation_Id,
                    Week = item.Week,
                    State = item.State,

                });
            }
            return imputationResponses;
        }



        public static ImputationModel ToImputationModelMapper(this ImputationDto imputationDto)
        {
            return new ImputationModel()
            {
                Day = imputationDto.Day,
                State = imputationDto.State,
                Extra_Hours = imputationDto.Extra_Hours,
                Employee_Id = imputationDto.Employee_Id,
                Imputation_Id = imputationDto.Imputation_Id,
                Hours = imputationDto.Hours,
                Project_Id = imputationDto.Project_Id,
                Week = imputationDto.Week,
            };
        }

        public static List<ImputationModel> ToImputationModelMapper(this List<ImputationDto> imputationDtoList)
        {
            List<ImputationModel> result = new List<ImputationModel>();
            foreach (var item in imputationDtoList)
            {
                result.Add(new ImputationModel()
                {
                    Day = item.Day,
                    Employee_Id = item.Employee_Id,
                    Extra_Hours = item.Extra_Hours,
                    Hours = item.Hours,
                    Imputation_Id = item.Imputation_Id,
                    Project_Id = item.Project_Id,
                    State = item.State,
                    Week = item.Week

                });


            }

            return result;

        }
    }
}
