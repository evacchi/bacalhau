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
    /// ModelJobCreatePayload
    /// </summary>
    [DataContract]
        public partial class ModelJobCreatePayload :  IEquatable<ModelJobCreatePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelJobCreatePayload" /> class.
        /// </summary>
        /// <param name="clientID">the id of the client that is submitting the job (required).</param>
        /// <param name="context">Optional base64-encoded tar file that will be pinned to IPFS and mounted as storage for the job. Not part of the spec so we don&#x27;t flood the transport layer with it (potentially very large)..</param>
        /// <param name="job">job (required).</param>
        public ModelJobCreatePayload(string clientID = default(string), string context = default(string), ModelJob job = default(ModelJob))
        {
            // to ensure "clientID" is required (not null)
            if (clientID == null)
            {
                throw new InvalidDataException("clientID is a required property for ModelJobCreatePayload and cannot be null");
            }
            else
            {
                this.ClientID = clientID;
            }
            // to ensure "job" is required (not null)
            if (job == null)
            {
                throw new InvalidDataException("job is a required property for ModelJobCreatePayload and cannot be null");
            }
            else
            {
                this.Job = job;
            }
            this.Context = context;
        }
        
        /// <summary>
        /// the id of the client that is submitting the job
        /// </summary>
        /// <value>the id of the client that is submitting the job</value>
        [DataMember(Name="ClientID", EmitDefaultValue=false)]
        public string ClientID { get; set; }

        /// <summary>
        /// Optional base64-encoded tar file that will be pinned to IPFS and mounted as storage for the job. Not part of the spec so we don&#x27;t flood the transport layer with it (potentially very large).
        /// </summary>
        /// <value>Optional base64-encoded tar file that will be pinned to IPFS and mounted as storage for the job. Not part of the spec so we don&#x27;t flood the transport layer with it (potentially very large).</value>
        [DataMember(Name="Context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// Gets or Sets Job
        /// </summary>
        [DataMember(Name="Job", EmitDefaultValue=false)]
        public ModelJob Job { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelJobCreatePayload {\n");
            sb.Append("  ClientID: ").Append(ClientID).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
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
            return this.Equals(input as ModelJobCreatePayload);
        }

        /// <summary>
        /// Returns true if ModelJobCreatePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelJobCreatePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelJobCreatePayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientID == input.ClientID ||
                    (this.ClientID != null &&
                    this.ClientID.Equals(input.ClientID))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
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
                if (this.ClientID != null)
                    hashCode = hashCode * 59 + this.ClientID.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
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
