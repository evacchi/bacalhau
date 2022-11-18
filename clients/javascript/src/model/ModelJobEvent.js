/*
 * Bacalhau API
 * This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: team@bacalhau.org
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 3.0.35
 *
 * Do not edit the class manually.
 *
 */
import {ApiClient} from '../ApiClient';
import {ModelDeal} from './ModelDeal';
import {ModelJobExecutionPlan} from './ModelJobExecutionPlan';
import {ModelRunCommandResult} from './ModelRunCommandResult';
import {ModelSpec} from './ModelSpec';
import {ModelStorageSpec} from './ModelStorageSpec';
import {ModelVerificationResult} from './ModelVerificationResult';

/**
 * The ModelJobEvent model module.
 * @module model/ModelJobEvent
 * @version 0.3.13
 */
export class ModelJobEvent {
  /**
   * Constructs a new <code>ModelJobEvent</code>.
   * @alias module:model/ModelJobEvent
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>ModelJobEvent</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ModelJobEvent} obj Optional instance to populate.
   * @return {module:model/ModelJobEvent} The populated <code>ModelJobEvent</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new ModelJobEvent();
      if (data.hasOwnProperty('APIVersion'))
        obj.aPIVersion = ApiClient.convertToType(data['APIVersion'], 'String');
      if (data.hasOwnProperty('ClientID'))
        obj.clientID = ApiClient.convertToType(data['ClientID'], 'String');
      if (data.hasOwnProperty('Deal'))
        obj.deal = ModelDeal.constructFromObject(data['Deal']);
      if (data.hasOwnProperty('EventName'))
        obj.eventName = ApiClient.convertToType(data['EventName'], 'Number');
      if (data.hasOwnProperty('EventTime'))
        obj.eventTime = ApiClient.convertToType(data['EventTime'], 'String');
      if (data.hasOwnProperty('JobExecutionPlan'))
        obj.jobExecutionPlan = ModelJobExecutionPlan.constructFromObject(data['JobExecutionPlan']);
      if (data.hasOwnProperty('JobID'))
        obj.jobID = ApiClient.convertToType(data['JobID'], 'String');
      if (data.hasOwnProperty('PublishedResult'))
        obj.publishedResult = ModelStorageSpec.constructFromObject(data['PublishedResult']);
      if (data.hasOwnProperty('RunOutput'))
        obj.runOutput = ModelRunCommandResult.constructFromObject(data['RunOutput']);
      if (data.hasOwnProperty('SenderPublicKey'))
        obj.senderPublicKey = ApiClient.convertToType(data['SenderPublicKey'], ['Number']);
      if (data.hasOwnProperty('ShardIndex'))
        obj.shardIndex = ApiClient.convertToType(data['ShardIndex'], 'Number');
      if (data.hasOwnProperty('SourceNodeID'))
        obj.sourceNodeID = ApiClient.convertToType(data['SourceNodeID'], 'String');
      if (data.hasOwnProperty('Spec'))
        obj.spec = ModelSpec.constructFromObject(data['Spec']);
      if (data.hasOwnProperty('Status'))
        obj.status = ApiClient.convertToType(data['Status'], 'String');
      if (data.hasOwnProperty('TargetNodeID'))
        obj.targetNodeID = ApiClient.convertToType(data['TargetNodeID'], 'String');
      if (data.hasOwnProperty('VerificationProposal'))
        obj.verificationProposal = ApiClient.convertToType(data['VerificationProposal'], ['Number']);
      if (data.hasOwnProperty('VerificationResult'))
        obj.verificationResult = ModelVerificationResult.constructFromObject(data['VerificationResult']);
    }
    return obj;
  }
}

/**
 * APIVersion of the Job
 * @member {String} aPIVersion
 */
ModelJobEvent.prototype.aPIVersion = undefined;

/**
 * optional clientID if this is an externally triggered event (like create job)
 * @member {String} clientID
 */
ModelJobEvent.prototype.clientID = undefined;

/**
 * @member {module:model/ModelDeal} deal
 */
ModelJobEvent.prototype.deal = undefined;

/**
 * @member {Number} eventName
 */
ModelJobEvent.prototype.eventName = undefined;

/**
 * @member {String} eventTime
 */
ModelJobEvent.prototype.eventTime = undefined;

/**
 * @member {module:model/ModelJobExecutionPlan} jobExecutionPlan
 */
ModelJobEvent.prototype.jobExecutionPlan = undefined;

/**
 * @member {String} jobID
 */
ModelJobEvent.prototype.jobID = undefined;

/**
 * @member {module:model/ModelStorageSpec} publishedResult
 */
ModelJobEvent.prototype.publishedResult = undefined;

/**
 * @member {module:model/ModelRunCommandResult} runOutput
 */
ModelJobEvent.prototype.runOutput = undefined;

/**
 * @member {Array.<Number>} senderPublicKey
 */
ModelJobEvent.prototype.senderPublicKey = undefined;

/**
 * what shard is this event for
 * @member {Number} shardIndex
 */
ModelJobEvent.prototype.shardIndex = undefined;

/**
 * the node that emitted this event
 * @member {String} sourceNodeID
 */
ModelJobEvent.prototype.sourceNodeID = undefined;

/**
 * @member {module:model/ModelSpec} spec
 */
ModelJobEvent.prototype.spec = undefined;

/**
 * @member {String} status
 */
ModelJobEvent.prototype.status = undefined;

/**
 * the node that this event is for e.g. \"AcceptJobBid\" was emitted by Requester but it targeting compute node
 * @member {String} targetNodeID
 */
ModelJobEvent.prototype.targetNodeID = undefined;

/**
 * @member {Array.<Number>} verificationProposal
 */
ModelJobEvent.prototype.verificationProposal = undefined;

/**
 * @member {module:model/ModelVerificationResult} verificationResult
 */
ModelJobEvent.prototype.verificationResult = undefined;

