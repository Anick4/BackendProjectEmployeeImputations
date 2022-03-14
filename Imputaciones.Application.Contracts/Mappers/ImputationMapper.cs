﻿using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Requests;
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
        public static List<ImputationModel> ToListImputationModel(this List<Imputation> imputations)
        {
            List<ImputationModel> imputationModelList = new ();
            foreach (var item in imputations)
            {
                imputationModelList.Add(item.ToImputationModel());
            }
            return imputationModelList;

        }

        public static ImputationModel ToImputationModel(this Imputation imputation)
        {
            return new ImputationModel ()
            {
                Day = imputation.Day,
                State = imputation.State,
                Extra_Hours = imputation.Extra_Hours,
                Projects_Id = imputation.Project_Id,
                Employees_Id = imputation.Employee_Id,
                Imputation_Id = imputation.Imputation_Id,
                Hours = imputation.Hours,
                Week = imputation.Week
            };
        }

        //public static List<ImputationResponse> ToImputationsResponse(this List<ImputationModel> imputationList)
        //{ //LE PASAMOS COMO PARAMETRO OTRA LISTA CON TODOS LOS PROJECTS BY EMPLOYEE
        //   List<ImputationResponse> imputationResponses = new ();

        //    var projectIds = imputationList.Select(x => x.Projects_Id).Distinct().ToList();
        //    foreach(var item in projectIds)
        //    {
               
        //       ImputationResponse imputationResponse = new ();
        //         // Necesito comprobar que no se repita el id del proyecto
                
        //       imputationResponse.ProjectName = "nombre";
        //       imputationResponse.ProjectId = item;

                
        //       imputationResponse.Imputations = imputationList.Where(x => x.Projects_Id == item).ToList().ToImputationResponse();
        //       imputationResponses.Add(imputationResponse); //CAMBIAR CUANDO HAGAMOS EL INCLUDE
        //    }

        //    //List<Project> projects = new List<Project> ();
        //    //var result = GetAllProjects();
        //    //projects.Add(getAllProjects(imputationList.))

        //    return imputationResponses;
        //}

        
        //AQUI SACO LA RESPONSE BUENA
        public static List<ImputationResponseBase> ToImputationResponse(this List<ImputationModel> imputationModelList)
        {
            List<ImputationResponseBase> imputationResponses = new ();
            foreach(var item in imputationModelList)
            {
                
                imputationResponses.Add(new ImputationResponseBase()
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
            return new ImputationModel ()
            {
                Day = imputationDto.Day,
                State = imputationDto.State,
                Extra_Hours = imputationDto.Extra_Hours,
                Projects_Id = imputationDto.Project_Id,
                Employees_Id = imputationDto.Employee_Id,
                Imputation_Id = imputationDto.Imputation_Id,
                Hours = imputationDto.Hours,
                Week = imputationDto.Week
            };
        }

        public static List<ImputationModel> ToImputationModelMapper(this List<ImputationDto> imputationDtoList)
        {
            List<ImputationModel> result = new ();
            foreach (var item in imputationDtoList)
            {
                result.Add(new ImputationModel ()
                {
                    Day = item.Day,
                    Projects_Id = item.Project_Id,
                    Employees_Id = item.Employee_Id,
                    Extra_Hours = item.Extra_Hours,
                    Hours = item.Hours,
                    Imputation_Id = item.Imputation_Id,
                    State = item.State,
                    Week = item.Week

                });


            }

            return result;

        }

        public static List<ImputationResponseModel> ToListModelResponseMapper(this List<ImputationResponseDto> imputationResponseDtoList)
        {
            List<ImputationResponseModel> result = new ();
            foreach (var item in imputationResponseDtoList)
            {
                var model = new ImputationResponseModel()
                {
                    ProjectName = item.ProjectName,
                    ProjectId = item.ProjectId,
                    Imputations = item.Imputations,

                };
                result.Add(model);
            }

             return result;
        }

        public static List<ImputationResponse> ToListImputationsResponse(this List<ImputationResponseModel> imputationResponseModelList)
        {
            List<ImputationResponse> result = new ();
            foreach (var item in imputationResponseModelList)
            {
                var model = new ImputationResponse()
                {
                    ProjectName = item.ProjectName,
                    ProjectId = item.ProjectId,
                    Imputations = item.Imputations,

                };
                result.Add(model);
            }

            return result;
        }

        public static ImputationModel ToImputationModelMapper(this ImputationInsertRequestBase imputationRequest)
        {
            var result = new ImputationModel()
            {
                Date = imputationRequest.Date,
                Name
            }
        }
    }
}
