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
    /// ModelJobExecutionPlan
    /// </summary>
    [DataContract]
        public partial class ModelJobExecutionPlan :  IEquatable<ModelJobExecutionPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelJobExecutionPlan" /> class.
        /// </summary>
        /// <param name="shardsTotal">how many shards are there in total for this job we are expecting this number x concurrency total JobShardState objects for this job.</param>
        public ModelJobExecutionPlan(int? shardsTotal = default(int?))
        {
            this.ShardsTotal = shardsTotal;
        }
        
        /// <summary>
        /// how many shards are there in total for this job we are expecting this number x concurrency total JobShardState objects for this job
        /// </summary>
        /// <value>how many shards are there in total for this job we are expecting this number x concurrency total JobShardState objects for this job</value>
        [DataMember(Name="ShardsTotal", EmitDefaultValue=false)]
        public int? ShardsTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelJobExecutionPlan {\n");
            sb.Append("  ShardsTotal: ").Append(ShardsTotal).Append("\n");
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
            return this.Equals(input as ModelJobExecutionPlan);
        }

        /// <summary>
        /// Returns true if ModelJobExecutionPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelJobExecutionPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelJobExecutionPlan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShardsTotal == input.ShardsTotal ||
                    (this.ShardsTotal != null &&
                    this.ShardsTotal.Equals(input.ShardsTotal))
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
                if (this.ShardsTotal != null)
                    hashCode = hashCode * 59 + this.ShardsTotal.GetHashCode();
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
