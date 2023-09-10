// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = UseSourceGeneration.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using UseSourceGeneration.Client;

namespace UseSourceGeneration.Model
{
    /// <summary>
    /// HasOnlyReadOnly
    /// </summary>
    public partial class HasOnlyReadOnly : IEquatable<HasOnlyReadOnly?>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HasOnlyReadOnly" /> class.
        /// </summary>
        /// <param name="bar">bar</param>
        /// <param name="foo">foo</param>
        [JsonConstructor]
        internal HasOnlyReadOnly(string bar, string foo)
        {
            Bar = bar;
            Foo = foo;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Bar
        /// </summary>
        [JsonPropertyName("bar")]
        public string Bar { get; }

        /// <summary>
        /// Gets or Sets Foo
        /// </summary>
        [JsonPropertyName("foo")]
        public string Foo { get; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HasOnlyReadOnly {\n");
            sb.Append("  Bar: ").Append(Bar).Append("\n");
            sb.Append("  Foo: ").Append(Foo).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as HasOnlyReadOnly).AreEqual;
        }

        /// <summary>
        /// Returns true if HasOnlyReadOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of HasOnlyReadOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HasOnlyReadOnly? input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + Bar.GetHashCode();
                hashCode = (hashCode * 59) + Foo.GetHashCode();
                hashCode = (hashCode * 59) + AdditionalProperties.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="HasOnlyReadOnly" />
    /// </summary>
    public class HasOnlyReadOnlyJsonConverter : JsonConverter<HasOnlyReadOnly>
    {
        /// <summary>
        /// Deserializes json to <see cref="HasOnlyReadOnly" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override HasOnlyReadOnly Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? bar = default;
            string? foo = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "bar":
                            bar = utf8JsonReader.GetString();
                            break;
                        case "foo":
                            foo = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (bar == null)
                throw new ArgumentNullException(nameof(bar), "Property is required for class HasOnlyReadOnly.");

            if (foo == null)
                throw new ArgumentNullException(nameof(foo), "Property is required for class HasOnlyReadOnly.");

            return new HasOnlyReadOnly(bar, foo);
        }

        /// <summary>
        /// Serializes a <see cref="HasOnlyReadOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="hasOnlyReadOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, HasOnlyReadOnly hasOnlyReadOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, hasOnlyReadOnly, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="HasOnlyReadOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="hasOnlyReadOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, HasOnlyReadOnly hasOnlyReadOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("bar", hasOnlyReadOnly.Bar);
            writer.WriteString("foo", hasOnlyReadOnly.Foo);
        }
    }

    /// <summary>
    /// The HasOnlyReadOnlySerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(HasOnlyReadOnly))]
    public partial class HasOnlyReadOnlySerializationContext : JsonSerializerContext
    {
        /// <summary>
        /// The HasOnlyReadOnlySerializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public HasOnlyReadOnlySerializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }

    /// <summary>
    /// HasOnlyReadOnlyDeserializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata)]
    [JsonSerializable(typeof(HasOnlyReadOnly))]
    public partial class HasOnlyReadOnlyDeserializationContext : JsonSerializerContext
    {
        /// <summary>
        /// HasOnlyReadOnlyDeserializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public HasOnlyReadOnlyDeserializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }
}
