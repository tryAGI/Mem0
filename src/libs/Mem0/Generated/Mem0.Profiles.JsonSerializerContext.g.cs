
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsUpdateRequestEntities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsUpdateRequestEntitiesUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesCreateJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesCreateJobRequestOperation), TypeInfoPropertyName = "ProfilesCreateJobRequestOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesCreateJobRequestEntityType), TypeInfoPropertyName = "ProfilesCreateJobRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesReadEntityType), TypeInfoPropertyName = "ProfilesReadEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesReadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesReadResponseStatus), TypeInfoPropertyName = "ProfilesReadResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesReadResponseEntityType), TypeInfoPropertyName = "ProfilesReadResponseEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsReadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsReadResponseEntities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsReadResponseEntitiesUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsReadResponseCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsUpdateResponseEntities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsUpdateResponseEntitiesUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesSettingsUpdateResponseCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesCreateJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesGetJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesGetJobResponseJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesGetJobResponseJobStatus), TypeInfoPropertyName = "ProfilesGetJobResponseJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesCreateJobRequestOperation?), TypeInfoPropertyName = "NullableProfilesCreateJobRequestOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesCreateJobRequestEntityType?), TypeInfoPropertyName = "NullableProfilesCreateJobRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesReadEntityType?), TypeInfoPropertyName = "NullableProfilesReadEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesReadResponseStatus?), TypeInfoPropertyName = "NullableProfilesReadResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesReadResponseEntityType?), TypeInfoPropertyName = "NullableProfilesReadResponseEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.ProfilesGetJobResponseJobStatus?), TypeInfoPropertyName = "NullableProfilesGetJobResponseJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class ProfilesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProfilesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProfilesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Mem0.JsonConverters.OneOfJsonConverter<int?, double?, string>());
            options.Converters.Add(new global::Mem0.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Mem0.ProfilesCreateJobRequestOperation)

                    || typeToConvert == typeof(global::Mem0.ProfilesCreateJobRequestOperation?)

                    || typeToConvert == typeof(global::Mem0.ProfilesCreateJobRequestEntityType)

                    || typeToConvert == typeof(global::Mem0.ProfilesCreateJobRequestEntityType?)

                    || typeToConvert == typeof(global::Mem0.ProfilesReadEntityType)

                    || typeToConvert == typeof(global::Mem0.ProfilesReadEntityType?)

                    || typeToConvert == typeof(global::Mem0.ProfilesReadResponseStatus)

                    || typeToConvert == typeof(global::Mem0.ProfilesReadResponseStatus?)

                    || typeToConvert == typeof(global::Mem0.ProfilesReadResponseEntityType)

                    || typeToConvert == typeof(global::Mem0.ProfilesReadResponseEntityType?)

                    || typeToConvert == typeof(global::Mem0.ProfilesGetJobResponseJobStatus)

                    || typeToConvert == typeof(global::Mem0.ProfilesGetJobResponseJobStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mem0.ProfilesCreateJobRequestOperation))
                {
                    return new global::Mem0.JsonConverters.ProfilesCreateJobRequestOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesCreateJobRequestOperation?))
                {
                    return new global::Mem0.JsonConverters.ProfilesCreateJobRequestOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesCreateJobRequestEntityType))
                {
                    return new global::Mem0.JsonConverters.ProfilesCreateJobRequestEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesCreateJobRequestEntityType?))
                {
                    return new global::Mem0.JsonConverters.ProfilesCreateJobRequestEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesReadEntityType))
                {
                    return new global::Mem0.JsonConverters.ProfilesReadEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesReadEntityType?))
                {
                    return new global::Mem0.JsonConverters.ProfilesReadEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesReadResponseStatus))
                {
                    return new global::Mem0.JsonConverters.ProfilesReadResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesReadResponseStatus?))
                {
                    return new global::Mem0.JsonConverters.ProfilesReadResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesReadResponseEntityType))
                {
                    return new global::Mem0.JsonConverters.ProfilesReadResponseEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesReadResponseEntityType?))
                {
                    return new global::Mem0.JsonConverters.ProfilesReadResponseEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesGetJobResponseJobStatus))
                {
                    return new global::Mem0.JsonConverters.ProfilesGetJobResponseJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.ProfilesGetJobResponseJobStatus?))
                {
                    return new global::Mem0.JsonConverters.ProfilesGetJobResponseJobStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ProfilesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}