
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.CreateOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.UpdateOrganizationMemberRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.AddOrganizationMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mem0.RemoveOrganizationMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.OrganizationsReadResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.OrganizationsReadResponseItemMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetOrganizationResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mem0.GetOrganizationMembersResponseMember>))]
    internal sealed partial class OrganizationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrganizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrganizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    0 => new OrganizationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}