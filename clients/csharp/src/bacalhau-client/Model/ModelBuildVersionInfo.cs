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
    /// ModelBuildVersionInfo
    /// </summary>
    [DataContract]
        public partial class ModelBuildVersionInfo :  IEquatable<ModelBuildVersionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBuildVersionInfo" /> class.
        /// </summary>
        /// <param name="builddate">builddate.</param>
        /// <param name="gitcommit">gitcommit.</param>
        /// <param name="gitversion">gitversion.</param>
        /// <param name="goarch">goarch.</param>
        /// <param name="goos">goos.</param>
        /// <param name="major">major.</param>
        /// <param name="minor">minor.</param>
        public ModelBuildVersionInfo(string builddate = default(string), string gitcommit = default(string), string gitversion = default(string), string goarch = default(string), string goos = default(string), string major = default(string), string minor = default(string))
        {
            this.Builddate = builddate;
            this.Gitcommit = gitcommit;
            this.Gitversion = gitversion;
            this.Goarch = goarch;
            this.Goos = goos;
            this.Major = major;
            this.Minor = minor;
        }
        
        /// <summary>
        /// Gets or Sets Builddate
        /// </summary>
        [DataMember(Name="builddate", EmitDefaultValue=false)]
        public string Builddate { get; set; }

        /// <summary>
        /// Gets or Sets Gitcommit
        /// </summary>
        [DataMember(Name="gitcommit", EmitDefaultValue=false)]
        public string Gitcommit { get; set; }

        /// <summary>
        /// Gets or Sets Gitversion
        /// </summary>
        [DataMember(Name="gitversion", EmitDefaultValue=false)]
        public string Gitversion { get; set; }

        /// <summary>
        /// Gets or Sets Goarch
        /// </summary>
        [DataMember(Name="goarch", EmitDefaultValue=false)]
        public string Goarch { get; set; }

        /// <summary>
        /// Gets or Sets Goos
        /// </summary>
        [DataMember(Name="goos", EmitDefaultValue=false)]
        public string Goos { get; set; }

        /// <summary>
        /// Gets or Sets Major
        /// </summary>
        [DataMember(Name="major", EmitDefaultValue=false)]
        public string Major { get; set; }

        /// <summary>
        /// Gets or Sets Minor
        /// </summary>
        [DataMember(Name="minor", EmitDefaultValue=false)]
        public string Minor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelBuildVersionInfo {\n");
            sb.Append("  Builddate: ").Append(Builddate).Append("\n");
            sb.Append("  Gitcommit: ").Append(Gitcommit).Append("\n");
            sb.Append("  Gitversion: ").Append(Gitversion).Append("\n");
            sb.Append("  Goarch: ").Append(Goarch).Append("\n");
            sb.Append("  Goos: ").Append(Goos).Append("\n");
            sb.Append("  Major: ").Append(Major).Append("\n");
            sb.Append("  Minor: ").Append(Minor).Append("\n");
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
            return this.Equals(input as ModelBuildVersionInfo);
        }

        /// <summary>
        /// Returns true if ModelBuildVersionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelBuildVersionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelBuildVersionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Builddate == input.Builddate ||
                    (this.Builddate != null &&
                    this.Builddate.Equals(input.Builddate))
                ) && 
                (
                    this.Gitcommit == input.Gitcommit ||
                    (this.Gitcommit != null &&
                    this.Gitcommit.Equals(input.Gitcommit))
                ) && 
                (
                    this.Gitversion == input.Gitversion ||
                    (this.Gitversion != null &&
                    this.Gitversion.Equals(input.Gitversion))
                ) && 
                (
                    this.Goarch == input.Goarch ||
                    (this.Goarch != null &&
                    this.Goarch.Equals(input.Goarch))
                ) && 
                (
                    this.Goos == input.Goos ||
                    (this.Goos != null &&
                    this.Goos.Equals(input.Goos))
                ) && 
                (
                    this.Major == input.Major ||
                    (this.Major != null &&
                    this.Major.Equals(input.Major))
                ) && 
                (
                    this.Minor == input.Minor ||
                    (this.Minor != null &&
                    this.Minor.Equals(input.Minor))
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
                if (this.Builddate != null)
                    hashCode = hashCode * 59 + this.Builddate.GetHashCode();
                if (this.Gitcommit != null)
                    hashCode = hashCode * 59 + this.Gitcommit.GetHashCode();
                if (this.Gitversion != null)
                    hashCode = hashCode * 59 + this.Gitversion.GetHashCode();
                if (this.Goarch != null)
                    hashCode = hashCode * 59 + this.Goarch.GetHashCode();
                if (this.Goos != null)
                    hashCode = hashCode * 59 + this.Goos.GetHashCode();
                if (this.Major != null)
                    hashCode = hashCode * 59 + this.Major.GetHashCode();
                if (this.Minor != null)
                    hashCode = hashCode * 59 + this.Minor.GetHashCode();
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
