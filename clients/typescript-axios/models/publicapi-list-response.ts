/* tslint:disable */
/* eslint-disable */
/**
 * Bacalhau API
 * This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: team@bacalhau.org
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
import { ModelJob } from './model-job';
/**
 * 
 * @export
 * @interface PublicapiListResponse
 */
export interface PublicapiListResponse {
    /**
     * 
     * @type {Array<ModelJob>}
     * @memberof PublicapiListResponse
     */
    jobs?: Array<ModelJob>;
}
