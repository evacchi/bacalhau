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
    /// PublicapiListRequest
    /// </summary>
    [DataContract]
        public partial class PublicapiListRequest :  IEquatable<PublicapiListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicapiListRequest" /> class.
        /// </summary>
        /// <param name="clientId">clientId.</param>
        /// <param name="id">id.</param>
        /// <param name="maxJobs">maxJobs.</param>
        /// <param name="returnAll">returnAll.</param>
        /// <param name="sortBy">sortBy.</param>
        /// <param name="sortReverse">sortReverse.</param>
        public PublicapiListRequest(string clientId = default(string), string id = default(string), int? maxJobs = default(int?), bool? returnAll = default(bool?), string sortBy = default(string), bool? sortReverse = default(bool?))
        {
            this.ClientId = clientId;
            this.Id = id;
            this.MaxJobs = maxJobs;
            this.ReturnAll = returnAll;
            this.SortBy = sortBy;
            this.SortReverse = sortReverse;
        }
        
        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets MaxJobs
        /// </summary>
        [DataMember(Name="max_jobs", EmitDefaultValue=false)]
        public int? MaxJobs { get; set; }

        /// <summary>
        /// Gets or Sets ReturnAll
        /// </summary>
        [DataMember(Name="return_all", EmitDefaultValue=false)]
        public bool? ReturnAll { get; set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name="sort_by", EmitDefaultValue=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// Gets or Sets SortReverse
        /// </summary>
        [DataMember(Name="sort_reverse", EmitDefaultValue=false)]
        public bool? SortReverse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicapiListRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaxJobs: ").Append(MaxJobs).Append("\n");
            sb.Append("  ReturnAll: ").Append(ReturnAll).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortReverse: ").Append(SortReverse).Append("\n");
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
            return this.Equals(input as PublicapiListRequest);
        }

        /// <summary>
        /// Returns true if PublicapiListRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicapiListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicapiListRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MaxJobs == input.MaxJobs ||
                    (this.MaxJobs != null &&
                    this.MaxJobs.Equals(input.MaxJobs))
                ) && 
                (
                    this.ReturnAll == input.ReturnAll ||
                    (this.ReturnAll != null &&
                    this.ReturnAll.Equals(input.ReturnAll))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
                ) && 
                (
                    this.SortReverse == input.SortReverse ||
                    (this.SortReverse != null &&
                    this.SortReverse.Equals(input.SortReverse))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MaxJobs != null)
                    hashCode = hashCode * 59 + this.MaxJobs.GetHashCode();
                if (this.ReturnAll != null)
                    hashCode = hashCode * 59 + this.ReturnAll.GetHashCode();
                if (this.SortBy != null)
                    hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.SortReverse != null)
                    hashCode = hashCode * 59 + this.SortReverse.GetHashCode();
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
