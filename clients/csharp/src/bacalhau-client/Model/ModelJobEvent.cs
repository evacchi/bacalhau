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
    /// ModelJobEvent
    /// </summary>
    [DataContract]
        public partial class ModelJobEvent :  IEquatable<ModelJobEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelJobEvent" /> class.
        /// </summary>
        /// <param name="aPIVersion">APIVersion of the Job.</param>
        /// <param name="clientID">optional clientID if this is an externally triggered event (like create job).</param>
        /// <param name="deal">deal.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventTime">eventTime.</param>
        /// <param name="jobExecutionPlan">jobExecutionPlan.</param>
        /// <param name="jobID">jobID.</param>
        /// <param name="publishedResult">publishedResult.</param>
        /// <param name="runOutput">runOutput.</param>
        /// <param name="senderPublicKey">senderPublicKey.</param>
        /// <param name="shardIndex">what shard is this event for.</param>
        /// <param name="sourceNodeID">the node that emitted this event.</param>
        /// <param name="spec">spec.</param>
        /// <param name="status">status.</param>
        /// <param name="targetNodeID">the node that this event is for e.g. \&quot;AcceptJobBid\&quot; was emitted by Requester but it targeting compute node.</param>
        /// <param name="verificationProposal">verificationProposal.</param>
        /// <param name="verificationResult">verificationResult.</param>
        public ModelJobEvent(string aPIVersion = default(string), string clientID = default(string), ModelDeal deal = default(ModelDeal), int? eventName = default(int?), string eventTime = default(string), ModelJobExecutionPlan jobExecutionPlan = default(ModelJobExecutionPlan), string jobID = default(string), ModelStorageSpec publishedResult = default(ModelStorageSpec), ModelRunCommandResult runOutput = default(ModelRunCommandResult), List<int?> senderPublicKey = default(List<int?>), int? shardIndex = default(int?), string sourceNodeID = default(string), ModelSpec spec = default(ModelSpec), string status = default(string), string targetNodeID = default(string), List<int?> verificationProposal = default(List<int?>), ModelVerificationResult verificationResult = default(ModelVerificationResult))
        {
            this.APIVersion = aPIVersion;
            this.ClientID = clientID;
            this.Deal = deal;
            this.EventName = eventName;
            this.EventTime = eventTime;
            this.JobExecutionPlan = jobExecutionPlan;
            this.JobID = jobID;
            this.PublishedResult = publishedResult;
            this.RunOutput = runOutput;
            this.SenderPublicKey = senderPublicKey;
            this.ShardIndex = shardIndex;
            this.SourceNodeID = sourceNodeID;
            this.Spec = spec;
            this.Status = status;
            this.TargetNodeID = targetNodeID;
            this.VerificationProposal = verificationProposal;
            this.VerificationResult = verificationResult;
        }
        
        /// <summary>
        /// APIVersion of the Job
        /// </summary>
        /// <value>APIVersion of the Job</value>
        [DataMember(Name="APIVersion", EmitDefaultValue=false)]
        public string APIVersion { get; set; }

        /// <summary>
        /// optional clientID if this is an externally triggered event (like create job)
        /// </summary>
        /// <value>optional clientID if this is an externally triggered event (like create job)</value>
        [DataMember(Name="ClientID", EmitDefaultValue=false)]
        public string ClientID { get; set; }

        /// <summary>
        /// Gets or Sets Deal
        /// </summary>
        [DataMember(Name="Deal", EmitDefaultValue=false)]
        public ModelDeal Deal { get; set; }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="EventName", EmitDefaultValue=false)]
        public int? EventName { get; set; }

        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="EventTime", EmitDefaultValue=false)]
        public string EventTime { get; set; }

        /// <summary>
        /// Gets or Sets JobExecutionPlan
        /// </summary>
        [DataMember(Name="JobExecutionPlan", EmitDefaultValue=false)]
        public ModelJobExecutionPlan JobExecutionPlan { get; set; }

        /// <summary>
        /// Gets or Sets JobID
        /// </summary>
        [DataMember(Name="JobID", EmitDefaultValue=false)]
        public string JobID { get; set; }

        /// <summary>
        /// Gets or Sets PublishedResult
        /// </summary>
        [DataMember(Name="PublishedResult", EmitDefaultValue=false)]
        public ModelStorageSpec PublishedResult { get; set; }

        /// <summary>
        /// Gets or Sets RunOutput
        /// </summary>
        [DataMember(Name="RunOutput", EmitDefaultValue=false)]
        public ModelRunCommandResult RunOutput { get; set; }

        /// <summary>
        /// Gets or Sets SenderPublicKey
        /// </summary>
        [DataMember(Name="SenderPublicKey", EmitDefaultValue=false)]
        public List<int?> SenderPublicKey { get; set; }

        /// <summary>
        /// what shard is this event for
        /// </summary>
        /// <value>what shard is this event for</value>
        [DataMember(Name="ShardIndex", EmitDefaultValue=false)]
        public int? ShardIndex { get; set; }

        /// <summary>
        /// the node that emitted this event
        /// </summary>
        /// <value>the node that emitted this event</value>
        [DataMember(Name="SourceNodeID", EmitDefaultValue=false)]
        public string SourceNodeID { get; set; }

        /// <summary>
        /// Gets or Sets Spec
        /// </summary>
        [DataMember(Name="Spec", EmitDefaultValue=false)]
        public ModelSpec Spec { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// the node that this event is for e.g. \&quot;AcceptJobBid\&quot; was emitted by Requester but it targeting compute node
        /// </summary>
        /// <value>the node that this event is for e.g. \&quot;AcceptJobBid\&quot; was emitted by Requester but it targeting compute node</value>
        [DataMember(Name="TargetNodeID", EmitDefaultValue=false)]
        public string TargetNodeID { get; set; }

        /// <summary>
        /// Gets or Sets VerificationProposal
        /// </summary>
        [DataMember(Name="VerificationProposal", EmitDefaultValue=false)]
        public List<int?> VerificationProposal { get; set; }

        /// <summary>
        /// Gets or Sets VerificationResult
        /// </summary>
        [DataMember(Name="VerificationResult", EmitDefaultValue=false)]
        public ModelVerificationResult VerificationResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelJobEvent {\n");
            sb.Append("  APIVersion: ").Append(APIVersion).Append("\n");
            sb.Append("  ClientID: ").Append(ClientID).Append("\n");
            sb.Append("  Deal: ").Append(Deal).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  JobExecutionPlan: ").Append(JobExecutionPlan).Append("\n");
            sb.Append("  JobID: ").Append(JobID).Append("\n");
            sb.Append("  PublishedResult: ").Append(PublishedResult).Append("\n");
            sb.Append("  RunOutput: ").Append(RunOutput).Append("\n");
            sb.Append("  SenderPublicKey: ").Append(SenderPublicKey).Append("\n");
            sb.Append("  ShardIndex: ").Append(ShardIndex).Append("\n");
            sb.Append("  SourceNodeID: ").Append(SourceNodeID).Append("\n");
            sb.Append("  Spec: ").Append(Spec).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TargetNodeID: ").Append(TargetNodeID).Append("\n");
            sb.Append("  VerificationProposal: ").Append(VerificationProposal).Append("\n");
            sb.Append("  VerificationResult: ").Append(VerificationResult).Append("\n");
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
            return this.Equals(input as ModelJobEvent);
        }

        /// <summary>
        /// Returns true if ModelJobEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelJobEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelJobEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.APIVersion == input.APIVersion ||
                    (this.APIVersion != null &&
                    this.APIVersion.Equals(input.APIVersion))
                ) && 
                (
                    this.ClientID == input.ClientID ||
                    (this.ClientID != null &&
                    this.ClientID.Equals(input.ClientID))
                ) && 
                (
                    this.Deal == input.Deal ||
                    (this.Deal != null &&
                    this.Deal.Equals(input.Deal))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.EventTime == input.EventTime ||
                    (this.EventTime != null &&
                    this.EventTime.Equals(input.EventTime))
                ) && 
                (
                    this.JobExecutionPlan == input.JobExecutionPlan ||
                    (this.JobExecutionPlan != null &&
                    this.JobExecutionPlan.Equals(input.JobExecutionPlan))
                ) && 
                (
                    this.JobID == input.JobID ||
                    (this.JobID != null &&
                    this.JobID.Equals(input.JobID))
                ) && 
                (
                    this.PublishedResult == input.PublishedResult ||
                    (this.PublishedResult != null &&
                    this.PublishedResult.Equals(input.PublishedResult))
                ) && 
                (
                    this.RunOutput == input.RunOutput ||
                    (this.RunOutput != null &&
                    this.RunOutput.Equals(input.RunOutput))
                ) && 
                (
                    this.SenderPublicKey == input.SenderPublicKey ||
                    this.SenderPublicKey != null &&
                    input.SenderPublicKey != null &&
                    this.SenderPublicKey.SequenceEqual(input.SenderPublicKey)
                ) && 
                (
                    this.ShardIndex == input.ShardIndex ||
                    (this.ShardIndex != null &&
                    this.ShardIndex.Equals(input.ShardIndex))
                ) && 
                (
                    this.SourceNodeID == input.SourceNodeID ||
                    (this.SourceNodeID != null &&
                    this.SourceNodeID.Equals(input.SourceNodeID))
                ) && 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TargetNodeID == input.TargetNodeID ||
                    (this.TargetNodeID != null &&
                    this.TargetNodeID.Equals(input.TargetNodeID))
                ) && 
                (
                    this.VerificationProposal == input.VerificationProposal ||
                    this.VerificationProposal != null &&
                    input.VerificationProposal != null &&
                    this.VerificationProposal.SequenceEqual(input.VerificationProposal)
                ) && 
                (
                    this.VerificationResult == input.VerificationResult ||
                    (this.VerificationResult != null &&
                    this.VerificationResult.Equals(input.VerificationResult))
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
                if (this.APIVersion != null)
                    hashCode = hashCode * 59 + this.APIVersion.GetHashCode();
                if (this.ClientID != null)
                    hashCode = hashCode * 59 + this.ClientID.GetHashCode();
                if (this.Deal != null)
                    hashCode = hashCode * 59 + this.Deal.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventTime != null)
                    hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                if (this.JobExecutionPlan != null)
                    hashCode = hashCode * 59 + this.JobExecutionPlan.GetHashCode();
                if (this.JobID != null)
                    hashCode = hashCode * 59 + this.JobID.GetHashCode();
                if (this.PublishedResult != null)
                    hashCode = hashCode * 59 + this.PublishedResult.GetHashCode();
                if (this.RunOutput != null)
                    hashCode = hashCode * 59 + this.RunOutput.GetHashCode();
                if (this.SenderPublicKey != null)
                    hashCode = hashCode * 59 + this.SenderPublicKey.GetHashCode();
                if (this.ShardIndex != null)
                    hashCode = hashCode * 59 + this.ShardIndex.GetHashCode();
                if (this.SourceNodeID != null)
                    hashCode = hashCode * 59 + this.SourceNodeID.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TargetNodeID != null)
                    hashCode = hashCode * 59 + this.TargetNodeID.GetHashCode();
                if (this.VerificationProposal != null)
                    hashCode = hashCode * 59 + this.VerificationProposal.GetHashCode();
                if (this.VerificationResult != null)
                    hashCode = hashCode * 59 + this.VerificationResult.GetHashCode();
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
