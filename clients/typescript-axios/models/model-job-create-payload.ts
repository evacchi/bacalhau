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
 * @interface ModelJobCreatePayload
 */
export interface ModelJobCreatePayload {
    /**
     * the id of the client that is submitting the job
     * @type {string}
     * @memberof ModelJobCreatePayload
     */
    clientID: string;
    /**
     * Optional base64-encoded tar file that will be pinned to IPFS and mounted as storage for the job. Not part of the spec so we don't flood the transport layer with it (potentially very large).
     * @type {string}
     * @memberof ModelJobCreatePayload
     */
    context?: string;
    /**
     * 
     * @type {ModelJob}
     * @memberof ModelJobCreatePayload
     */
    job: ModelJob;
}
