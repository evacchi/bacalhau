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
import {ModelRunCommandResult} from './ModelRunCommandResult';
import {ModelStorageSpec} from './ModelStorageSpec';
import {ModelVerificationResult} from './ModelVerificationResult';

/**
 * The ModelJobShardState model module.
 * @module model/ModelJobShardState
 * @version 0.3.13
 */
export class ModelJobShardState {
  /**
   * Constructs a new <code>ModelJobShardState</code>.
   * @alias module:model/ModelJobShardState
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>ModelJobShardState</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ModelJobShardState} obj Optional instance to populate.
   * @return {module:model/ModelJobShardState} The populated <code>ModelJobShardState</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new ModelJobShardState();
      if (data.hasOwnProperty('NodeId'))
        obj.nodeId = ApiClient.convertToType(data['NodeId'], 'String');
      if (data.hasOwnProperty('PublishedResults'))
        obj.publishedResults = ModelStorageSpec.constructFromObject(data['PublishedResults']);
      if (data.hasOwnProperty('RunOutput'))
        obj.runOutput = ModelRunCommandResult.constructFromObject(data['RunOutput']);
      if (data.hasOwnProperty('ShardIndex'))
        obj.shardIndex = ApiClient.convertToType(data['ShardIndex'], 'Number');
      if (data.hasOwnProperty('State'))
        obj.state = ApiClient.convertToType(data['State'], 'Number');
      if (data.hasOwnProperty('Status'))
        obj.status = ApiClient.convertToType(data['Status'], 'String');
      if (data.hasOwnProperty('VerificationProposal'))
        obj.verificationProposal = ApiClient.convertToType(data['VerificationProposal'], ['Number']);
      if (data.hasOwnProperty('VerificationResult'))
        obj.verificationResult = ModelVerificationResult.constructFromObject(data['VerificationResult']);
    }
    return obj;
  }
}

/**
 * which node is running this shard
 * @member {String} nodeId
 */
ModelJobShardState.prototype.nodeId = undefined;

/**
 * @member {module:model/ModelStorageSpec} publishedResults
 */
ModelJobShardState.prototype.publishedResults = undefined;

/**
 * @member {module:model/ModelRunCommandResult} runOutput
 */
ModelJobShardState.prototype.runOutput = undefined;

/**
 * what shard is this we are running
 * @member {Number} shardIndex
 */
ModelJobShardState.prototype.shardIndex = undefined;

/**
 * what is the state of the shard on this node
 * @member {Number} state
 */
ModelJobShardState.prototype.state = undefined;

/**
 * an arbitrary status message
 * @member {String} status
 */
ModelJobShardState.prototype.status = undefined;

/**
 * the proposed results for this shard this will be resolved by the verifier somehow
 * @member {Array.<Number>} verificationProposal
 */
ModelJobShardState.prototype.verificationProposal = undefined;

/**
 * @member {module:model/ModelVerificationResult} verificationResult
 */
ModelJobShardState.prototype.verificationResult = undefined;

