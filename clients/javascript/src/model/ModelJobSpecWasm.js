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
import {ModelStorageSpec} from './ModelStorageSpec';

/**
 * The ModelJobSpecWasm model module.
 * @module model/ModelJobSpecWasm
 * @version 0.3.13
 */
export class ModelJobSpecWasm {
  /**
   * Constructs a new <code>ModelJobSpecWasm</code>.
   * @alias module:model/ModelJobSpecWasm
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>ModelJobSpecWasm</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ModelJobSpecWasm} obj Optional instance to populate.
   * @return {module:model/ModelJobSpecWasm} The populated <code>ModelJobSpecWasm</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new ModelJobSpecWasm();
      if (data.hasOwnProperty('EntryPoint'))
        obj.entryPoint = ApiClient.convertToType(data['EntryPoint'], 'String');
      if (data.hasOwnProperty('EnvironmentVariables'))
        obj.environmentVariables = ApiClient.convertToType(data['EnvironmentVariables'], {'String': 'String'});
      if (data.hasOwnProperty('ImportModules'))
        obj.importModules = ApiClient.convertToType(data['ImportModules'], [ModelStorageSpec]);
      if (data.hasOwnProperty('Parameters'))
        obj.parameters = ApiClient.convertToType(data['Parameters'], ['String']);
    }
    return obj;
  }
}

/**
 * The name of the function in the EntryModule to call to run the job. For WASI jobs, this will always be `_start`, but jobs can choose to call other WASM functions instead. The EntryPoint must be a zero-parameter zero-result function.
 * @member {String} entryPoint
 */
ModelJobSpecWasm.prototype.entryPoint = undefined;

/**
 * The variables available in the environment of the running program.
 * @member {Object.<String, String>} environmentVariables
 */
ModelJobSpecWasm.prototype.environmentVariables = undefined;

/**
 * TODO #880: Other WASM modules whose exports will be available as imports to the EntryModule.
 * @member {Array.<module:model/ModelStorageSpec>} importModules
 */
ModelJobSpecWasm.prototype.importModules = undefined;

/**
 * The arguments supplied to the program (i.e. as ARGV).
 * @member {Array.<String>} parameters
 */
ModelJobSpecWasm.prototype.parameters = undefined;

