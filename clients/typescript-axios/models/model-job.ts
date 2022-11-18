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
import { ModelDeal } from './model-deal';
import { ModelJobEvent } from './model-job-event';
import { ModelJobExecutionPlan } from './model-job-execution-plan';
import { ModelJobLocalEvent } from './model-job-local-event';
import { ModelJobState } from './model-job-state';
import { ModelSpec } from './model-spec';
/**
 * 
 * @export
 * @interface ModelJob
 */
export interface ModelJob {
    /**
     * 
     * @type {string}
     * @memberof ModelJob
     */
    aPIVersion?: string;
    /**
     * The ID of the client that created this job.
     * @type {string}
     * @memberof ModelJob
     */
    clientID?: string;
    /**
     * Time the job was submitted to the bacalhau network.
     * @type {string}
     * @memberof ModelJob
     */
    createdAt?: string;
    /**
     * 
     * @type {ModelDeal}
     * @memberof ModelJob
     */
    deal?: ModelDeal;
    /**
     * 
     * @type {ModelJobExecutionPlan}
     * @memberof ModelJob
     */
    executionPlan?: ModelJobExecutionPlan;
    /**
     * The unique global ID of this job in the bacalhau network.
     * @type {string}
     * @memberof ModelJob
     */
    ID?: string;
    /**
     * All events associated with the job
     * @type {Array<ModelJobEvent>}
     * @memberof ModelJob
     */
    jobEvents?: Array<ModelJobEvent>;
    /**
     * 
     * @type {ModelJobState}
     * @memberof ModelJob
     */
    jobState?: ModelJobState;
    /**
     * All local events associated with the job
     * @type {Array<ModelJobLocalEvent>}
     * @memberof ModelJob
     */
    localJobEvents?: Array<ModelJobLocalEvent>;
    /**
     * The ID of the requester node that owns this job.
     * @type {string}
     * @memberof ModelJob
     */
    requesterNodeID?: string;
    /**
     * The public key of the Requester node that created this job This can be used to encrypt messages back to the creator
     * @type {Array<number>}
     * @memberof ModelJob
     */
    requesterPublicKey?: Array<number>;
    /**
     * 
     * @type {ModelSpec}
     * @memberof ModelJob
     */
    spec?: ModelSpec;
}
