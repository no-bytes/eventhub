﻿using AutoMapper;
using EventHub.Events;
using EventHub.Organizations;
using EventHub.Web.Pages.Organizations;
using EditPageModel = EventHub.Web.Pages.Events.EditPageModel;

namespace EventHub.Web
{
    public class EventHubWebAutoMapperProfile : Profile
    {
        public EventHubWebAutoMapperProfile()
        {
            CreateMap<NewPageModel.CreateOrganizationViewModel, CreateOrganizationDto>();
            CreateMap<Pages.Events.NewPageModel.NewEventViewModel, CreateEventDto>();
            CreateMap<OrganizationProfileDto, EditOrganizationViewModel>();
            CreateMap<EditOrganizationViewModel, UpdateOrganizationDto>();
            CreateMap<EventDetailDto, EditPageModel.EditEventViewModel>();
            CreateMap<EditPageModel.EditEventViewModel, UpdateEventDto>();
            CreateMap<EventDetailDto, EditPageModel.EditEventTimingViewModel>();
        }
    }
}
