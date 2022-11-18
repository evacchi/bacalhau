/* 
 * Bacalhau API
 *
 * This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: team@bacalhau.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = bacalhau-client.Client.SwaggerDateConverter;

namespace bacalhau-client.Model
{
    /// <summary>
    /// ModelJobShardingConfig
    /// </summary>
    [DataContract]
        public partial class ModelJobShardingConfig :  IEquatable<ModelJobShardingConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelJobShardingConfig" /> class.
        /// </summary>
        /// <param name="batchSize">how many \&quot;items\&quot; are to be processed in each shard we first apply the glob pattern which will result in a flat list of items this number decides how to group that flat list into actual shards run by compute nodes.</param>
        /// <param name="globPattern">divide the inputs up into the smallest possible unit for example /_* would mean \&quot;all top level files or folders\&quot; this being an empty string means \&quot;no sharding\&quot;.</param>
        /// <param name="globPatternBasePath">when using multiple input volumes what path do we treat as the common mount path to apply the glob pattern to.</param>
        public ModelJobShardingConfig(int? batchSize = default(int?), string globPattern = default(string), string globPatternBasePath = default(string))
        {
            this.BatchSize = batchSize;
            this.GlobPattern = globPattern;
            this.GlobPatternBasePath = globPatternBasePath;
        }
        
        /// <summary>
        /// how many \&quot;items\&quot; are to be processed in each shard we first apply the glob pattern which will result in a flat list of items this number decides how to group that flat list into actual shards run by compute nodes
        /// </summary>
        /// <value>how many \&quot;items\&quot; are to be processed in each shard we first apply the glob pattern which will result in a flat list of items this number decides how to group that flat list into actual shards run by compute nodes</value>
        [DataMember(Name="BatchSize", EmitDefaultValue=false)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// divide the inputs up into the smallest possible unit for example /_* would mean \&quot;all top level files or folders\&quot; this being an empty string means \&quot;no sharding\&quot;
        /// </summary>
        /// <value>divide the inputs up into the smallest possible unit for example /_* would mean \&quot;all top level files or folders\&quot; this being an empty string means \&quot;no sharding\&quot;</value>
        [DataMember(Name="GlobPattern", EmitDefaultValue=false)]
        public string GlobPattern { get; set; }

        /// <summary>
        /// when using multiple input volumes what path do we treat as the common mount path to apply the glob pattern to
        /// </summary>
        /// <value>when using multiple input volumes what path do we treat as the common mount path to apply the glob pattern to</value>
        [DataMember(Name="GlobPatternBasePath", EmitDefaultValue=false)]
        public string GlobPatternBasePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelJobShardingConfig {\n");
            sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  GlobPattern: ").Append(GlobPattern).Append("\n");
            sb.Append("  GlobPatternBasePath: ").Append(GlobPatternBasePath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelJobShardingConfig);
        }

        /// <summary>
        /// Returns true if ModelJobShardingConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelJobShardingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelJobShardingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchSize == input.BatchSize ||
                    (this.BatchSize != null &&
                    this.BatchSize.Equals(input.BatchSize))
                ) && 
                (
                    this.GlobPattern == input.GlobPattern ||
                    (this.GlobPattern != null &&
                    this.GlobPattern.Equals(input.GlobPattern))
                ) && 
                (
                    this.GlobPatternBasePath == input.GlobPatternBasePath ||
                    (this.GlobPatternBasePath != null &&
                    this.GlobPatternBasePath.Equals(input.GlobPatternBasePath))
                );
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
                if (this.BatchSize != null)
                    hashCode = hashCode * 59 + this.BatchSize.GetHashCode();
                if (this.GlobPattern != null)
                    hashCode = hashCode * 59 + this.GlobPattern.GetHashCode();
                if (this.GlobPatternBasePath != null)
                    hashCode = hashCode * 59 + this.GlobPatternBasePath.GetHashCode();
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
}
