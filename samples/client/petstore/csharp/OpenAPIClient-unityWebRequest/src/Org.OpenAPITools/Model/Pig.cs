/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Pig
    /// </summary>
    [JsonConverter(typeof(PigJsonConverter))]
    [DataContract(Name = "Pig")]
    public partial class Pig : AbstractOpenAPISchema, IEquatable<Pig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pig" /> class
        /// with the <see cref="BasquePig" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BasquePig.</param>
        public Pig(BasquePig actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pig" /> class
        /// with the <see cref="DanishPig" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DanishPig.</param>
        public Pig(DanishPig actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(BasquePig))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DanishPig))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: BasquePig, DanishPig");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `BasquePig`. If the actual instance is not `BasquePig`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BasquePig</returns>
        public BasquePig GetBasquePig()
        {
            return (BasquePig)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DanishPig`. If the actual instance is not `DanishPig`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DanishPig</returns>
        public DanishPig GetDanishPig()
        {
            return (DanishPig)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pig {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, Pig.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Pig
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Pig</returns>
        public static Pig FromJson(string jsonString)
        {
            Pig newPig = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPig;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(BasquePig).GetProperty("AdditionalProperties") == null)
                {
                    newPig = new Pig(JsonConvert.DeserializeObject<BasquePig>(jsonString, Pig.SerializerSettings));
                }
                else
                {
                    newPig = new Pig(JsonConvert.DeserializeObject<BasquePig>(jsonString, Pig.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("BasquePig");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into BasquePig: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DanishPig).GetProperty("AdditionalProperties") == null)
                {
                    newPig = new Pig(JsonConvert.DeserializeObject<DanishPig>(jsonString, Pig.SerializerSettings));
                }
                else
                {
                    newPig = new Pig(JsonConvert.DeserializeObject<DanishPig>(jsonString, Pig.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DanishPig");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DanishPig: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newPig;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Pig);
        }

        /// <summary>
        /// Returns true if Pig instances are equal
        /// </summary>
        /// <param name="input">Instance of Pig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pig input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }
    }

    /// <summary>
    /// Custom JSON converter for Pig
    /// </summary>
    public class PigJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Pig).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return Pig.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
