
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Mem0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateAgent? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AgentResponse? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateApp? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AppResponse? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoryInput? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemorySearchInput? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemorySearchInputV2? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemorySearchInputV2Filters? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemorySearchInputV2Filters2? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemorySearchInputV2FiltersKeywords? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemorySearchInputV2FiltersCategories? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoryGetInputV2? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoryGetInputV2Filters? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoryGetInputV2Filters2? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoryGetInputV2FiltersKeywords? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoryGetInputV2FiltersCategories? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateRun? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.RunResponse? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateUser? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UserResponse? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteMemoriesInput? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetMemoryInput? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateMemoryInput? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntityInput? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntityInputEntityType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ExportsCreateRequest? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ExportsListRequest? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ExportsListRequestFilters? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListV3Request? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesAddV3Request? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesAddV3RequestMessage>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesAddV3RequestMessage? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesAddV3RequestMessageRole? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesSearchV3Request? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<int?, double?, string>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesUpdateRequest? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.SummaryCreateRequest? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.SubmitFeedbackRequest? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.SubmitFeedbackRequestFeedback? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateOrganizationRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateOrganizationMemberRoleRequest? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AddOrganizationMemberRequest? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.RemoveOrganizationMemberRequest? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateProjectRequest? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateProjectRequest? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AddProjectMemberRequest? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateProjectMemberRequest? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesBatchUpdateRequest? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesBatchUpdateRequestMemorie>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesBatchUpdateRequestMemorie? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesBatchDeleteRequest? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesBatchDeleteRequestMemorie>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesBatchDeleteRequestMemorie? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateWebhookRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.CreateWebhookRequestEventType>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateWebhookRequestEventType? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateWebhookRequest? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.UpdateWebhookRequestEventType>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateWebhookRequestEventType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateDreamConfigRequest? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateDreamConfigRequestReflectionMode? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsUpdateRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsUpdateRequestEntities? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsUpdateRequestEntitiesUser? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesCreateJobRequest? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesCreateJobRequestOperation? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesCreateJobRequestEntityType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesDeleteV1EntityType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesReadEntityType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesDeleteEntityType? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEntityReadEntityType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesReadEntityType? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesListResponse? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.EntitiesListResponseResult>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesListResponseResult? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesListResponseResultType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesFiltersListResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.EntitiesFiltersListResponseParameter>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesFiltersListResponseParameter? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.EntitiesFiltersListResponseParameterOption>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesFiltersListResponseParameterOption? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesDeleteV1Response? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesDeleteV1Response2? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.EntitiesReadResponseItem>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesReadResponseItem? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesDeleteResponse? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EntitiesDeleteResponse2? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EventsListResponse? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.EventsListResponseResult>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EventsListResponseResult? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EventsListResponseResultStatus? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EventReadResponse? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EventReadResponseStatus? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.EventReadResponse2? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ExportsCreateResponse? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<global::Mem0.ExportsCreateResponseVariant1, global::Mem0.ExportsCreateResponseVariant2>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ExportsCreateResponseVariant1? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ExportsCreateResponseVariant2? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ExportsListResponse2? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ExportsListResponse3? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<global::System.Collections.Generic.IList<global::Mem0.MemoriesListResponseItem>, global::Mem0.MemoriesListResponse2>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesListResponseItem>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListResponseItem? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListResponse2? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesListResponseResult>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListResponseResult? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<global::System.Collections.Generic.IList<string>, global::Mem0.MemoriesListResponse4>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListResponse4? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListResponse5? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<global::System.Collections.Generic.IList<global::Mem0.MemoriesCreateResponseItem>, global::Mem0.MemoriesCreateResponse2>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesCreateResponseItem>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesCreateResponseItem? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesCreateResponse2? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesCreateResponseResult>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesCreateResponseResult? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesDeleteAllResponse? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesListV2ResponseItem>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListV2ResponseItem? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListV2Response? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEventsListResponse? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesEventsListResponseResult>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEventsListResponseResult? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesEventsListResponseResultInputItem>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEventsListResponseResultInputItem? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEventsListResponseResultEvent? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEventsListResponse2? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchCreateResponseItem>, global::Mem0.MemoriesSearchCreateResponse2>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchCreateResponseItem>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesSearchCreateResponseItem? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesSearchCreateResponse2? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchCreateResponseResult>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesSearchCreateResponseResult? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesSearchCreateResponse3? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchV2ResponseItem>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesSearchV2ResponseItem? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListV3Response? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesListV3ResponseResult>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesListV3ResponseResult? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesAddV3Response? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesAddV3ResponseStatus? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesAddV3ResponseResult>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesAddV3ResponseResult? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesAddV3ResponseResultData? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesSearchV3Response? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesSearchV3ResponseResult>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesSearchV3ResponseResult? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesSearchV3ResponseResultScoreBreakdown? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEntityReadResponse? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesEntityReadResponseResult>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEntityReadResponseResult? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesEntityReadResponseResultInputItem>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEntityReadResponseResultInputItem? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEntityReadResponse2? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesEntityReadResponse3? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesReadResponse? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesReadResponse2? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesReadResponse3? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesUpdateResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesUpdateResponse2? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesUpdateResponse3? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesDeleteResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesDeleteResponse2? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesDeleteResponse3? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItem>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesHistoryListResponseItem? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.MemoriesHistoryListResponseItemInputItem>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesHistoryListResponseItemInputItem? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesHistoryListResponseItemInputItemRole? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesHistoryListResponseItemEvent? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.StatsListResponse? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.PingReadResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.PingReadResponse2? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.SubmitFeedbackResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.SubmitFeedbackResponseFeedback? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.OrganizationsReadResponseItem>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OrganizationsReadResponseItem? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.OrganizationsReadResponseItemMember>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OrganizationsReadResponseItemMember? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateOrganizationResponse? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateOrganizationResponse2? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetOrganizationResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetOrganizationResponseMember>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetOrganizationResponseMember? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetOrganizationResponse2? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteOrganizationResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteOrganizationResponse2? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteOrganizationResponse3? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetOrganizationMembersResponse? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetOrganizationMembersResponseMember>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetOrganizationMembersResponseMember? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetOrganizationMembersResponse2? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateOrganizationMemberRoleResponse? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateOrganizationMemberRoleResponse2? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateOrganizationMemberRoleResponse3? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AddOrganizationMemberResponse? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AddOrganizationMemberResponse2? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AddOrganizationMemberResponse3? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.RemoveOrganizationMemberResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.RemoveOrganizationMemberResponse2? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetProjectsResponseItem>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectsResponseItem? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetProjectsResponseItemMember>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectsResponseItemMember? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateProjectResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateProjectResponse2? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateProjectResponse3? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetProjectResponseMember>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectResponseMember? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectResponse2? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateProjectResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateProjectResponse2? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteProjectResponse? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteProjectResponse2? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteProjectResponse3? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectMembersResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetProjectMembersResponseMember>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectMembersResponseMember? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectMembersResponse2? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AddProjectMemberResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AddProjectMemberResponse2? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.AddProjectMemberResponse3? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateProjectMemberResponse? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateProjectMemberResponse2? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateProjectMemberResponse3? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteProjectMemberResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteProjectMemberResponse2? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteProjectMemberResponse3? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesBatchUpdateResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesBatchUpdateResponse2? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesBatchDeleteResponse? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.MemoriesBatchDeleteResponse2? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetProjectWebhooksResponseItem>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectWebhooksResponseItem? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetProjectWebhooksResponse? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateWebhookResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.CreateWebhookResponse3? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateWebhookResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateWebhookResponse3? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateWebhookResponse4? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteWebhookResponse? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteWebhookResponse2? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DeleteWebhookResponse3? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamConfigResponse? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamConfigResponseConfig? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamConfigResponseConfigReflectionMode? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamConfigResponseEntitlements? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Mem0.GetDreamConfigResponseEntitlementsFeatures2>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamConfigResponseEntitlementsFeatures2? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateDreamConfigResponse? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateDreamConfigResponseConfig? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateDreamConfigResponseConfigReflectionMode? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateDreamConfigResponseEntitlements? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Mem0.UpdateDreamConfigResponseEntitlementsFeatures2>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.UpdateDreamConfigResponseEntitlementsFeatures2? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamStatsResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamActivityResponse? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamActivityResponseResult>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamActivityResponseResult? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamActivityResponseResultTransition? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamActivityResponseResultReplacedBy? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamActivityResponseResultSource>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamActivityResponseResultSource? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamRunsResponse? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResult>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamRunsResponseResult? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSynthesizedItem>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamRunsResponseResultSynthesizedItem? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSynthesizedItemSource>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamRunsResponseResultSynthesizedItemSource? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunsResponseResultSource>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamRunsResponseResultSource? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamRunMemoriesResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunMemoriesResponseResult>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamRunMemoriesResponseResult? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamRunMemoriesResponseResultSource>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamRunMemoriesResponseResultSource? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamMemorySourcesResponse? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mem0.GetDreamMemorySourcesResponseSource>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamMemorySourcesResponseSource? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.GetDreamMemorySourcesResponseSourceLifecycleState? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.DreamPreviewResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesReadResponse? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesReadResponseStatus? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesReadResponseEntityType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsReadResponse? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsReadResponseEntities? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsReadResponseEntitiesUser? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsReadResponseCapabilities? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsUpdateResponse? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsUpdateResponseEntities? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsUpdateResponseEntitiesUser? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesSettingsUpdateResponseCapabilities? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesCreateJobResponse? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesGetJobResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesGetJobResponseJob? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.ProfilesGetJobResponseJobStatus? Type309 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesAddV3RequestMessage>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesBatchUpdateRequestMemorie>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesBatchDeleteRequestMemorie>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.CreateWebhookRequestEventType>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.UpdateWebhookRequestEventType>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.EntitiesListResponseResult>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.EntitiesFiltersListResponseParameter>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.EntitiesFiltersListResponseParameterOption>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.EntitiesReadResponseItem>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.EventsListResponseResult>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<global::System.Collections.Generic.List<global::Mem0.MemoriesListResponseItem>, global::Mem0.MemoriesListResponse2>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesListResponseItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesListResponseResult>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<global::System.Collections.Generic.List<string>, global::Mem0.MemoriesListResponse4>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<global::System.Collections.Generic.List<global::Mem0.MemoriesCreateResponseItem>, global::Mem0.MemoriesCreateResponse2>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesCreateResponseItem>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesCreateResponseResult>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesListV2ResponseItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesEventsListResponseResult>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesEventsListResponseResultInputItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mem0.OneOf<global::System.Collections.Generic.List<global::Mem0.MemoriesSearchCreateResponseItem>, global::Mem0.MemoriesSearchCreateResponse2>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesSearchCreateResponseItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesSearchCreateResponseResult>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesSearchV2ResponseItem>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesListV3ResponseResult>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesAddV3ResponseResult>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesSearchV3ResponseResult>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesEntityReadResponseResult>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesEntityReadResponseResultInputItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesHistoryListResponseItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.MemoriesHistoryListResponseItemInputItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.OrganizationsReadResponseItem>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.OrganizationsReadResponseItemMember>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetOrganizationResponseMember>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetOrganizationMembersResponseMember>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetProjectsResponseItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetProjectsResponseItemMember>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetProjectResponseMember>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetProjectMembersResponseMember>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetProjectWebhooksResponseItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetDreamActivityResponseResult>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetDreamActivityResponseResultSource>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResult>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResultSynthesizedItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResultSynthesizedItemSource>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResultSource>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetDreamRunMemoriesResponseResult>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetDreamRunMemoriesResponseResultSource>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mem0.GetDreamMemorySourcesResponseSource>? ListType51 { get; set; }
    }
}