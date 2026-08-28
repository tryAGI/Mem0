
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Mem0.JsonConverters.EntityInputEntityTypeJsonConverter),

            typeof(global::Mem0.JsonConverters.EntityInputEntityTypeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesAddV3RequestMessageRoleJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesAddV3RequestMessageRoleNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.SubmitFeedbackRequestFeedbackJsonConverter),

            typeof(global::Mem0.JsonConverters.SubmitFeedbackRequestFeedbackNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.CreateWebhookRequestEventTypeJsonConverter),

            typeof(global::Mem0.JsonConverters.CreateWebhookRequestEventTypeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.UpdateWebhookRequestEventTypeJsonConverter),

            typeof(global::Mem0.JsonConverters.UpdateWebhookRequestEventTypeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.UpdateDreamConfigRequestReflectionModeJsonConverter),

            typeof(global::Mem0.JsonConverters.UpdateDreamConfigRequestReflectionModeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.EntitiesDeleteV1EntityTypeJsonConverter),

            typeof(global::Mem0.JsonConverters.EntitiesDeleteV1EntityTypeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.EntitiesReadEntityTypeJsonConverter),

            typeof(global::Mem0.JsonConverters.EntitiesReadEntityTypeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.EntitiesDeleteEntityTypeJsonConverter),

            typeof(global::Mem0.JsonConverters.EntitiesDeleteEntityTypeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesEntityReadEntityTypeJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesEntityReadEntityTypeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.EntitiesListResponseResultTypeJsonConverter),

            typeof(global::Mem0.JsonConverters.EntitiesListResponseResultTypeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.EventsListResponseResultStatusJsonConverter),

            typeof(global::Mem0.JsonConverters.EventsListResponseResultStatusNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.EventReadResponseStatusJsonConverter),

            typeof(global::Mem0.JsonConverters.EventReadResponseStatusNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesEventsListResponseResultEventJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesEventsListResponseResultEventNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesAddV3ResponseStatusJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesAddV3ResponseStatusNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesHistoryListResponseItemInputItemRoleJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesHistoryListResponseItemInputItemRoleNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesHistoryListResponseItemEventJsonConverter),

            typeof(global::Mem0.JsonConverters.MemoriesHistoryListResponseItemEventNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.SubmitFeedbackResponseFeedbackJsonConverter),

            typeof(global::Mem0.JsonConverters.SubmitFeedbackResponseFeedbackNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.GetDreamConfigResponseConfigReflectionModeJsonConverter),

            typeof(global::Mem0.JsonConverters.GetDreamConfigResponseConfigReflectionModeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.UpdateDreamConfigResponseConfigReflectionModeJsonConverter),

            typeof(global::Mem0.JsonConverters.UpdateDreamConfigResponseConfigReflectionModeNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.GetDreamActivityResponseResultTransitionJsonConverter),

            typeof(global::Mem0.JsonConverters.GetDreamActivityResponseResultTransitionNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.GetDreamMemorySourcesResponseSourceLifecycleStateJsonConverter),

            typeof(global::Mem0.JsonConverters.GetDreamMemorySourcesResponseSourceLifecycleStateNullableJsonConverter),

            typeof(global::Mem0.JsonConverters.OneOfJsonConverter<int?, double?, string>),

            typeof(global::Mem0.JsonConverters.OneOfJsonConverter<global::Mem0.ExportsCreateResponseVariant1, global::Mem0.ExportsCreateResponseVariant2>),

            typeof(global::Mem0.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Mem0.MemoriesListResponseItem>, global::Mem0.MemoriesListResponse2>),

            typeof(global::Mem0.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Mem0.MemoriesListResponse4>),

            typeof(global::Mem0.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Mem0.MemoriesCreateResponseItem>, global::Mem0.MemoriesCreateResponse2>),

            typeof(global::Mem0.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchCreateResponseItem>, global::Mem0.MemoriesSearchCreateResponse2>),

            typeof(global::Mem0.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoryInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string?>>), TypeInfoPropertyName = "IListDictionaryStringString_System_Collections_Generic_IList_global_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemorySearchInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemorySearchInputV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemorySearchInputV2Filters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemorySearchInputV2Filters2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemorySearchInputV2FiltersKeywords))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemorySearchInputV2FiltersCategories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoryGetInputV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoryGetInputV2Filters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoryGetInputV2Filters2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoryGetInputV2FiltersKeywords))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoryGetInputV2FiltersCategories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.RunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteMemoriesInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetMemoryInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateMemoryInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntityInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntityInputEntityType), TypeInfoPropertyName = "EntityInputEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ExportsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ExportsListRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ExportsListRequestFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesAddV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesAddV3RequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesAddV3RequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesAddV3RequestMessageRole), TypeInfoPropertyName = "MemoriesAddV3RequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>), TypeInfoPropertyName = "Dictionary_string_string_6a60df2668c88f71")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesSearchV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<int?, double?, string>), TypeInfoPropertyName = "OneOfInt32DoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.SummaryCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.SubmitFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.SubmitFeedbackRequestFeedback), TypeInfoPropertyName = "SubmitFeedbackRequestFeedback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateOrganizationMemberRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AddOrganizationMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.RemoveOrganizationMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AddProjectMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateProjectMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesBatchUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesBatchUpdateRequestMemorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesBatchUpdateRequestMemorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesBatchDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesBatchDeleteRequestMemorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesBatchDeleteRequestMemorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.CreateWebhookRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateWebhookRequestEventType), TypeInfoPropertyName = "CreateWebhookRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.UpdateWebhookRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateWebhookRequestEventType), TypeInfoPropertyName = "UpdateWebhookRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigRequestReflectionMode), TypeInfoPropertyName = "UpdateDreamConfigRequestReflectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesDeleteV1EntityType), TypeInfoPropertyName = "EntitiesDeleteV1EntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesReadEntityType), TypeInfoPropertyName = "EntitiesReadEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesDeleteEntityType), TypeInfoPropertyName = "EntitiesDeleteEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEntityReadEntityType), TypeInfoPropertyName = "MemoriesEntityReadEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.EntitiesListResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesListResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesListResponseResultType), TypeInfoPropertyName = "EntitiesListResponseResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesFiltersListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.EntitiesFiltersListResponseParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesFiltersListResponseParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.EntitiesFiltersListResponseParameterOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesFiltersListResponseParameterOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesDeleteV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesDeleteV1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.EntitiesReadResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesReadResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EntitiesDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EventsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.EventsListResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EventsListResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EventsListResponseResultStatus), TypeInfoPropertyName = "EventsListResponseResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EventReadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EventReadResponseStatus), TypeInfoPropertyName = "EventReadResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.EventReadResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ExportsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<global::Mem0.ExportsCreateResponseVariant1, global::Mem0.ExportsCreateResponseVariant2>), TypeInfoPropertyName = "OneOfExportsCreateResponseVariant1ExportsCreateResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ExportsCreateResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ExportsCreateResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ExportsListResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ExportsListResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<global::System.Collections.Generic.IList<global::Mem0.MemoriesListResponseItem>, global::Mem0.MemoriesListResponse2>), TypeInfoPropertyName = "OneOfIListMemoriesListResponseItemMemoriesListResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesListResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<global::System.Collections.Generic.IList<string>, global::Mem0.MemoriesListResponse4>), TypeInfoPropertyName = "OneOfIListStringMemoriesListResponse42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<global::System.Collections.Generic.IList<global::Mem0.MemoriesCreateResponseItem>, global::Mem0.MemoriesCreateResponse2>), TypeInfoPropertyName = "OneOfIListMemoriesCreateResponseItemMemoriesCreateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesCreateResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesCreateResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesCreateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesCreateResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesCreateResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesDeleteAllResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesListV2ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListV2ResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEventsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesEventsListResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEventsListResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesEventsListResponseResultInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEventsListResponseResultInputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEventsListResponseResultEvent), TypeInfoPropertyName = "MemoriesEventsListResponseResultEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEventsListResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchCreateResponseItem>, global::Mem0.MemoriesSearchCreateResponse2>), TypeInfoPropertyName = "OneOfIListMemoriesSearchCreateResponseItemMemoriesSearchCreateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchCreateResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesSearchCreateResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesSearchCreateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchCreateResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesSearchCreateResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesSearchCreateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchV2ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesSearchV2ResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesListV3ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesListV3ResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesAddV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesAddV3ResponseStatus), TypeInfoPropertyName = "MemoriesAddV3ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesAddV3ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesAddV3ResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesAddV3ResponseResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesSearchV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchV3ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesSearchV3ResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesSearchV3ResponseResultScoreBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEntityReadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesEntityReadResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEntityReadResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesEntityReadResponseResultInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEntityReadResponseResultInputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEntityReadResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesEntityReadResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesReadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesReadResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesReadResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesUpdateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesUpdateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesHistoryListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItemInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesHistoryListResponseItemInputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesHistoryListResponseItemInputItemRole), TypeInfoPropertyName = "MemoriesHistoryListResponseItemInputItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesHistoryListResponseItemEvent), TypeInfoPropertyName = "MemoriesHistoryListResponseItemEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.StatsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.PingReadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.PingReadResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.SubmitFeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.SubmitFeedbackResponseFeedback), TypeInfoPropertyName = "SubmitFeedbackResponseFeedback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.OrganizationsReadResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OrganizationsReadResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.OrganizationsReadResponseItemMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OrganizationsReadResponseItemMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateOrganizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateOrganizationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetOrganizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetOrganizationResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetOrganizationResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetOrganizationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteOrganizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteOrganizationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteOrganizationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetOrganizationMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetOrganizationMembersResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetOrganizationMembersResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetOrganizationMembersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateOrganizationMemberRoleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateOrganizationMemberRoleResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateOrganizationMemberRoleResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AddOrganizationMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AddOrganizationMemberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AddOrganizationMemberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.RemoveOrganizationMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.RemoveOrganizationMemberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetProjectsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetProjectsResponseItemMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectsResponseItemMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateProjectResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetProjectResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteProjectResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetProjectMembersResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectMembersResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectMembersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AddProjectMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AddProjectMemberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AddProjectMemberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateProjectMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateProjectMemberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateProjectMemberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteProjectMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteProjectMemberResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteProjectMemberResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesBatchUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesBatchUpdateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesBatchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.MemoriesBatchDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetProjectWebhooksResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectWebhooksResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetProjectWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateWebhookResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateWebhookResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateWebhookResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteWebhookResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DeleteWebhookResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamConfigResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamConfigResponseConfigReflectionMode), TypeInfoPropertyName = "GetDreamConfigResponseConfigReflectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamConfigResponseEntitlements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Mem0.GetDreamConfigResponseEntitlementsFeatures2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamConfigResponseEntitlementsFeatures2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigResponseConfigReflectionMode), TypeInfoPropertyName = "UpdateDreamConfigResponseConfigReflectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigResponseEntitlements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Mem0.UpdateDreamConfigResponseEntitlementsFeatures2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigResponseEntitlementsFeatures2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamActivityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetDreamActivityResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamActivityResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamActivityResponseResultTransition), TypeInfoPropertyName = "GetDreamActivityResponseResultTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamActivityResponseResultReplacedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetDreamActivityResponseResultSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamActivityResponseResultSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamRunsResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSynthesizedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamRunsResponseResultSynthesizedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSynthesizedItemSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamRunsResponseResultSynthesizedItemSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamRunsResponseResultSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamRunMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetDreamRunMemoriesResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamRunMemoriesResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetDreamRunMemoriesResponseResultSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamRunMemoriesResponseResultSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamMemorySourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mem0.GetDreamMemorySourcesResponseSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamMemorySourcesResponseSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamMemorySourcesResponseSourceLifecycleState), TypeInfoPropertyName = "GetDreamMemorySourcesResponseSourceLifecycleState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.DreamPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string?>>), TypeInfoPropertyName = "ListDictionaryStringString_System_Collections_Generic_List_global_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesAddV3RequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>), TypeInfoPropertyName = "ListDictionaryStringString_System_Collections_Generic_List_global_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesBatchUpdateRequestMemorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesBatchDeleteRequestMemorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.CreateWebhookRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.UpdateWebhookRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.EntitiesListResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.EntitiesFiltersListResponseParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.EntitiesFiltersListResponseParameterOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.EntitiesReadResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.EventsListResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<global::System.Collections.Generic.List<global::Mem0.MemoriesListResponseItem>, global::Mem0.MemoriesListResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesListResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<global::System.Collections.Generic.List<string>, global::Mem0.MemoriesListResponse4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<global::System.Collections.Generic.List<global::Mem0.MemoriesCreateResponseItem>, global::Mem0.MemoriesCreateResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesCreateResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesCreateResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesListV2ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesEventsListResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesEventsListResponseResultInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.OneOf<global::System.Collections.Generic.List<global::Mem0.MemoriesSearchCreateResponseItem>, global::Mem0.MemoriesSearchCreateResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesSearchCreateResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesSearchCreateResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesSearchV2ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesListV3ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesAddV3ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesSearchV3ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesEntityReadResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesEntityReadResponseResultInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesHistoryListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.MemoriesHistoryListResponseItemInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.OrganizationsReadResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.OrganizationsReadResponseItemMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetOrganizationResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetOrganizationMembersResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetProjectsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetProjectsResponseItemMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetProjectResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetProjectMembersResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetProjectWebhooksResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamActivityResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamActivityResponseResultSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResultSynthesizedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResultSynthesizedItemSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResultSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunMemoriesResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunMemoriesResponseResultSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamMemorySourcesResponseSource>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}