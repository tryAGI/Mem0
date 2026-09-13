
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigRequestReflectionMode), TypeInfoPropertyName = "UpdateDreamConfigRequestReflectionMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigRequestReflectionMode?), TypeInfoPropertyName = "NullableUpdateDreamConfigRequestReflectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamConfigResponseConfigReflectionMode?), TypeInfoPropertyName = "NullableGetDreamConfigResponseConfigReflectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateDreamConfigResponseConfigReflectionMode?), TypeInfoPropertyName = "NullableUpdateDreamConfigResponseConfigReflectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamActivityResponseResultTransition?), TypeInfoPropertyName = "NullableGetDreamActivityResponseResultTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.GetDreamMemorySourcesResponseSourceLifecycleState?), TypeInfoPropertyName = "NullableGetDreamMemorySourcesResponseSourceLifecycleState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamActivityResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamActivityResponseResultSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResultSynthesizedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResultSynthesizedItemSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunsResponseResultSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunMemoriesResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamRunMemoriesResponseResultSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetDreamMemorySourcesResponseSource>))]
    internal sealed partial class DreamSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DreamSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DreamSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DreamSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Mem0.UpdateDreamConfigRequestReflectionMode)

                    || typeToConvert == typeof(global::Mem0.UpdateDreamConfigRequestReflectionMode?)

                    || typeToConvert == typeof(global::Mem0.GetDreamConfigResponseConfigReflectionMode)

                    || typeToConvert == typeof(global::Mem0.GetDreamConfigResponseConfigReflectionMode?)

                    || typeToConvert == typeof(global::Mem0.UpdateDreamConfigResponseConfigReflectionMode)

                    || typeToConvert == typeof(global::Mem0.UpdateDreamConfigResponseConfigReflectionMode?)

                    || typeToConvert == typeof(global::Mem0.GetDreamActivityResponseResultTransition)

                    || typeToConvert == typeof(global::Mem0.GetDreamActivityResponseResultTransition?)

                    || typeToConvert == typeof(global::Mem0.GetDreamMemorySourcesResponseSourceLifecycleState)

                    || typeToConvert == typeof(global::Mem0.GetDreamMemorySourcesResponseSourceLifecycleState?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mem0.UpdateDreamConfigRequestReflectionMode))
                {
                    return new global::Mem0.JsonConverters.UpdateDreamConfigRequestReflectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.UpdateDreamConfigRequestReflectionMode?))
                {
                    return new global::Mem0.JsonConverters.UpdateDreamConfigRequestReflectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.GetDreamConfigResponseConfigReflectionMode))
                {
                    return new global::Mem0.JsonConverters.GetDreamConfigResponseConfigReflectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.GetDreamConfigResponseConfigReflectionMode?))
                {
                    return new global::Mem0.JsonConverters.GetDreamConfigResponseConfigReflectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.UpdateDreamConfigResponseConfigReflectionMode))
                {
                    return new global::Mem0.JsonConverters.UpdateDreamConfigResponseConfigReflectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.UpdateDreamConfigResponseConfigReflectionMode?))
                {
                    return new global::Mem0.JsonConverters.UpdateDreamConfigResponseConfigReflectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.GetDreamActivityResponseResultTransition))
                {
                    return new global::Mem0.JsonConverters.GetDreamActivityResponseResultTransitionJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.GetDreamActivityResponseResultTransition?))
                {
                    return new global::Mem0.JsonConverters.GetDreamActivityResponseResultTransitionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.GetDreamMemorySourcesResponseSourceLifecycleState))
                {
                    return new global::Mem0.JsonConverters.GetDreamMemorySourcesResponseSourceLifecycleStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Mem0.GetDreamMemorySourcesResponseSourceLifecycleState?))
                {
                    return new global::Mem0.JsonConverters.GetDreamMemorySourcesResponseSourceLifecycleStateNullableJsonConverter();
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
                    0 => new DreamSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}