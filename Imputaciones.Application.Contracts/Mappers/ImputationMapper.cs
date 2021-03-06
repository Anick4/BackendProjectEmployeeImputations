using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Requests;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class ImputationMapper
    {
        // List<Imputation> -> List<ImputationModel>
        public static List<ImputationModel> ToListImputationModel(this List<Imputation> imputations)
        {
            List<ImputationModel> imputationModelList = new ();
            foreach (var item in imputations)
            {
                imputationModelList.Add(item.ToImputationModel());
            }
            return imputationModelList;
        }


        // Entity Imputation -> ImputationModel
        public static ImputationModel ToImputationModel(this Imputation imputation)
        {
            return new ImputationModel ()
            {
                Day = imputation.Day,
                State = imputation.State,
                Extra_Hours = imputation.Extra_Hours,
                Project_Id = imputation.Project_Id,
                Employee_Id = imputation.Employee_Id,
                Imputation_Id = imputation.Imputation_Id,
                Hours = imputation.Hours,
                Week = imputation.Week
            };
        }


        // List<ImputationModel> -> List<ImputationResponseBase>
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


        // ImputationDto -> ImputationModel
        public static ImputationModel ToImputationModelMapper(this ImputationDto imputationDto)
        {
            return new ImputationModel ()
            {
                Day = imputationDto.Day,
                State = imputationDto.State,
                Extra_Hours = imputationDto.Extra_Hours,
                Project_Id = imputationDto.Project_Id,
                Employee_Id = imputationDto.Employee_Id,
                Imputation_Id = imputationDto.Imputation_Id,
                Hours = imputationDto.Hours,
                Week = imputationDto.Week
            };
        }


        // List<ImputationDto> -> List<ImputationModel>
        public static List<ImputationModel> ToImputationModelMapper(this List<ImputationDto> imputationDtoList)
        {
            List<ImputationModel> result = new ();
            foreach (var item in imputationDtoList)
            {
                result.Add(new ImputationModel ()
                {
                    Day = item.Day,
                    Project_Id = item.Project_Id,
                    Employee_Id = item.Employee_Id,
                    Extra_Hours = item.Extra_Hours,
                    Hours = item.Hours,
                    Imputation_Id = item.Imputation_Id,
                    State = item.State,
                    Week = item.Week
                });
            }
            return result;
        }


        // List<ImputationResponseDto> -> List<ImputationResponseModel>
        public static List<ImputationResponseModel> ToListModelResponseMapper(this List<ImputationResponseDto> imputationResponseDtoList)
        {
            List<ImputationResponseModel> result = new ();
            foreach (var item in imputationResponseDtoList)
            {
                var model = new ImputationResponseModel()
                {
                    ProjectName = item.ProjectName,
                    Projects_Id = item.ProjectId,
                    Imputations = item.Imputations
                };
                result.Add(model);
            }
             return result;
        }


        // List<ImputationResponseModel> -> List<ImputationResponse>
        public static List<ImputationResponse> ToListImputationsResponse(this List<ImputationResponseModel> imputationResponseModelList)
        {
            List<ImputationResponse> result = new ();
            foreach (var item in imputationResponseModelList)
            {
                var model = new ImputationResponse()
                {
                    ProjectName = item.ProjectName,
                    ProjectId = item.Projects_Id,
                    Imputations = item.Imputations
                };
                result.Add(model);
            }
            return result;
        }


        // List<ImputationInsertRequest> -> List<ImputationModel>
        public static List<ImputationModel> ToImputationModelMapper(this List<ImputationInsertRequest> imputationRequest)
        {
            List<ImputationModel> list = new();        
            foreach (var im in imputationRequest)
            {
                foreach(var item in im.Imputations!)
                {
                    list.Add(new ImputationModel()
                    {
                        Imputation_Id = item.Imputation_Id,
                        Project_Id = im.ProjectId,
                        Date = item.Date,
                        Day = item.Day,
                        Employee_Id = im.EmployeeId,
                        Hours = item.Hours,
                        Extra_Hours = item.Extra_Hours,
                        State = item.State,
                        Week = item.Week
                    });
                }               
            }
            return list;          
        }


        // ImputationModel -> Entity Imputation
        public static Imputation ToImputationMapper(this ImputationModel imputation)
        {
            return new()
            {
                Project_Id = imputation.Project_Id,
                Date = Convert.ToDateTime(imputation.Date),
                Day = imputation.Day,
                Employee_Id = imputation.Employee_Id,
                Hours = imputation.Hours,
                Extra_Hours = imputation.Extra_Hours,
                Imputation_Id = imputation.Imputation_Id,
                State = imputation.State,
                Week = imputation.Week
            };
        }


        // List<ImputationsForReviewDto> -> List<ImputationsForReviewModel>
        public static List<ImputationsForReviewModel> ToListModelMapper(this List<ImputationsForReviewDto> imputationList) {
            List<ImputationsForReviewModel> list = new();
            foreach(var item in imputationList)
            {
                list.Add(new ImputationsForReviewModel()
                {
                    Date = Convert.ToDateTime(item.Date),
                    EmployeeName = item.EmployeeName,
                    Hours = item.Hours,
                    ProjectId = item.ProjectId,
                    EmployeeId = item.EmployeeId,
                    ImputationId = item.ImputationId,
                    Status = item.Status,
                });
            }
            return list.OrderBy(x => x.Date).ToList();
        }


        // List<ImputationsForReviewModel> -> List<ImputationsForReviewResponse>
        public static List<ImputationsForReviewResponse> ToListResponseMapper(this List<ImputationsForReviewModel> imputationList)
        {
            List<ImputationsForReviewResponse> list = new();
            foreach (var item in imputationList)
            {
                list.Add(new ImputationsForReviewResponse()
                {
                    Date = item.Date.ToString("dd-MM-yyyy"),
                    EmployeeName = item.EmployeeName,
                    Hours = item.Hours,
                    ProjectId = item.ProjectId,
                    EmployeeId = item.EmployeeId,
                    ImputationId = item.ImputationId,
                    Status=item.Status,                   
                });
            }
            return list;
        }

        // List<TotalHoursDto> -> List<TotalHoursModel>

        public static List<TotalHoursModel> ToTotalHoursModelMapper(this List<TotalHoursDto> totalHoursList)
        {
            List<TotalHoursModel> list = new();
            foreach (var item in totalHoursList)
            {
                list.Add(new TotalHoursModel()
                {
                    Day = item.Day,
                    EmployeeName = item.EmployeeName,
                    TotalHours = item.TotalHours,
                });
            }
            return list;

        }
    }
}
