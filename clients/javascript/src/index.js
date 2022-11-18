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
import {ApiClient} from './ApiClient';
import {ComputenodeActiveJob} from './model/ComputenodeActiveJob';
import {ModelBuildVersionInfo} from './model/ModelBuildVersionInfo';
import {ModelDeal} from './model/ModelDeal';
import {ModelJob} from './model/ModelJob';
import {ModelJobCreatePayload} from './model/ModelJobCreatePayload';
import {ModelJobEvent} from './model/ModelJobEvent';
import {ModelJobExecutionPlan} from './model/ModelJobExecutionPlan';
import {ModelJobLocalEvent} from './model/ModelJobLocalEvent';
import {ModelJobNodeState} from './model/ModelJobNodeState';
import {ModelJobShardState} from './model/ModelJobShardState';
import {ModelJobShardingConfig} from './model/ModelJobShardingConfig';
import {ModelJobSpecDocker} from './model/ModelJobSpecDocker';
import {ModelJobSpecLanguage} from './model/ModelJobSpecLanguage';
import {ModelJobSpecWasm} from './model/ModelJobSpecWasm';
import {ModelJobState} from './model/ModelJobState';
import {ModelPublishedResult} from './model/ModelPublishedResult';
import {ModelResourceUsageConfig} from './model/ModelResourceUsageConfig';
import {ModelResourceUsageData} from './model/ModelResourceUsageData';
import {ModelRunCommandResult} from './model/ModelRunCommandResult';
import {ModelSpec} from './model/ModelSpec';
import {ModelStorageSpec} from './model/ModelStorageSpec';
import {ModelVerificationResult} from './model/ModelVerificationResult';
import {PublicapiDebugResponse} from './model/PublicapiDebugResponse';
import {PublicapiEventsRequest} from './model/PublicapiEventsRequest';
import {PublicapiEventsResponse} from './model/PublicapiEventsResponse';
import {PublicapiListRequest} from './model/PublicapiListRequest';
import {PublicapiListResponse} from './model/PublicapiListResponse';
import {PublicapiLocalEventsRequest} from './model/PublicapiLocalEventsRequest';
import {PublicapiLocalEventsResponse} from './model/PublicapiLocalEventsResponse';
import {PublicapiResultsResponse} from './model/PublicapiResultsResponse';
import {PublicapiStateRequest} from './model/PublicapiStateRequest';
import {PublicapiStateResponse} from './model/PublicapiStateResponse';
import {PublicapiSubmitRequest} from './model/PublicapiSubmitRequest';
import {PublicapiSubmitResponse} from './model/PublicapiSubmitResponse';
import {PublicapiVersionRequest} from './model/PublicapiVersionRequest';
import {PublicapiVersionResponse} from './model/PublicapiVersionResponse';
import {RequesternodeActiveJob} from './model/RequesternodeActiveJob';
import {TypesFreeSpace} from './model/TypesFreeSpace';
import {TypesHealthInfo} from './model/TypesHealthInfo';
import {TypesMountStatus} from './model/TypesMountStatus';
import {HealthApi} from './api/HealthApi';
import {JobApi} from './api/JobApi';
import {MiscApi} from './api/MiscApi';

/**
* This_page_is_the_reference_of_the_Bacalhau_REST_API__Project_docs_are_available_at_httpsdocs_bacalhau_org__Find_more_information_about_Bacalhau_at_httpsgithub_comfilecoin_projectbacalhau_.<br>
* The <code>index</code> module provides access to constructors for all the classes which comprise the public API.
* <p>
* An AMD (recommended!) or CommonJS application will generally do something equivalent to the following:
* <pre>
* var BacalhauClient = require('index'); // See note below*.
* var xxxSvc = new BacalhauClient.XxxApi(); // Allocate the API class we're going to use.
* var yyyModel = new BacalhauClient.Yyy(); // Construct a model instance.
* yyyModel.someProperty = 'someValue';
* ...
* var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
* ...
* </pre>
* <em>*NOTE: For a top-level AMD script, use require(['index'], function(){...})
* and put the application logic within the callback function.</em>
* </p>
* <p>
* A non-AMD browser application (discouraged) might do something like this:
* <pre>
* var xxxSvc = new BacalhauClient.XxxApi(); // Allocate the API class we're going to use.
* var yyy = new BacalhauClient.Yyy(); // Construct a model instance.
* yyyModel.someProperty = 'someValue';
* ...
* var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
* ...
* </pre>
* </p>
* @module index
* @version 0.3.13
*/
export {
    /**
     * The ApiClient constructor.
     * @property {module:ApiClient}
     */
    ApiClient,

    /**
     * The ComputenodeActiveJob model constructor.
     * @property {module:model/ComputenodeActiveJob}
     */
    ComputenodeActiveJob,

    /**
     * The ModelBuildVersionInfo model constructor.
     * @property {module:model/ModelBuildVersionInfo}
     */
    ModelBuildVersionInfo,

    /**
     * The ModelDeal model constructor.
     * @property {module:model/ModelDeal}
     */
    ModelDeal,

    /**
     * The ModelJob model constructor.
     * @property {module:model/ModelJob}
     */
    ModelJob,

    /**
     * The ModelJobCreatePayload model constructor.
     * @property {module:model/ModelJobCreatePayload}
     */
    ModelJobCreatePayload,

    /**
     * The ModelJobEvent model constructor.
     * @property {module:model/ModelJobEvent}
     */
    ModelJobEvent,

    /**
     * The ModelJobExecutionPlan model constructor.
     * @property {module:model/ModelJobExecutionPlan}
     */
    ModelJobExecutionPlan,

    /**
     * The ModelJobLocalEvent model constructor.
     * @property {module:model/ModelJobLocalEvent}
     */
    ModelJobLocalEvent,

    /**
     * The ModelJobNodeState model constructor.
     * @property {module:model/ModelJobNodeState}
     */
    ModelJobNodeState,

    /**
     * The ModelJobShardState model constructor.
     * @property {module:model/ModelJobShardState}
     */
    ModelJobShardState,

    /**
     * The ModelJobShardingConfig model constructor.
     * @property {module:model/ModelJobShardingConfig}
     */
    ModelJobShardingConfig,

    /**
     * The ModelJobSpecDocker model constructor.
     * @property {module:model/ModelJobSpecDocker}
     */
    ModelJobSpecDocker,

    /**
     * The ModelJobSpecLanguage model constructor.
     * @property {module:model/ModelJobSpecLanguage}
     */
    ModelJobSpecLanguage,

    /**
     * The ModelJobSpecWasm model constructor.
     * @property {module:model/ModelJobSpecWasm}
     */
    ModelJobSpecWasm,

    /**
     * The ModelJobState model constructor.
     * @property {module:model/ModelJobState}
     */
    ModelJobState,

    /**
     * The ModelPublishedResult model constructor.
     * @property {module:model/ModelPublishedResult}
     */
    ModelPublishedResult,

    /**
     * The ModelResourceUsageConfig model constructor.
     * @property {module:model/ModelResourceUsageConfig}
     */
    ModelResourceUsageConfig,

    /**
     * The ModelResourceUsageData model constructor.
     * @property {module:model/ModelResourceUsageData}
     */
    ModelResourceUsageData,

    /**
     * The ModelRunCommandResult model constructor.
     * @property {module:model/ModelRunCommandResult}
     */
    ModelRunCommandResult,

    /**
     * The ModelSpec model constructor.
     * @property {module:model/ModelSpec}
     */
    ModelSpec,

    /**
     * The ModelStorageSpec model constructor.
     * @property {module:model/ModelStorageSpec}
     */
    ModelStorageSpec,

    /**
     * The ModelVerificationResult model constructor.
     * @property {module:model/ModelVerificationResult}
     */
    ModelVerificationResult,

    /**
     * The PublicapiDebugResponse model constructor.
     * @property {module:model/PublicapiDebugResponse}
     */
    PublicapiDebugResponse,

    /**
     * The PublicapiEventsRequest model constructor.
     * @property {module:model/PublicapiEventsRequest}
     */
    PublicapiEventsRequest,

    /**
     * The PublicapiEventsResponse model constructor.
     * @property {module:model/PublicapiEventsResponse}
     */
    PublicapiEventsResponse,

    /**
     * The PublicapiListRequest model constructor.
     * @property {module:model/PublicapiListRequest}
     */
    PublicapiListRequest,

    /**
     * The PublicapiListResponse model constructor.
     * @property {module:model/PublicapiListResponse}
     */
    PublicapiListResponse,

    /**
     * The PublicapiLocalEventsRequest model constructor.
     * @property {module:model/PublicapiLocalEventsRequest}
     */
    PublicapiLocalEventsRequest,

    /**
     * The PublicapiLocalEventsResponse model constructor.
     * @property {module:model/PublicapiLocalEventsResponse}
     */
    PublicapiLocalEventsResponse,

    /**
     * The PublicapiResultsResponse model constructor.
     * @property {module:model/PublicapiResultsResponse}
     */
    PublicapiResultsResponse,

    /**
     * The PublicapiStateRequest model constructor.
     * @property {module:model/PublicapiStateRequest}
     */
    PublicapiStateRequest,

    /**
     * The PublicapiStateResponse model constructor.
     * @property {module:model/PublicapiStateResponse}
     */
    PublicapiStateResponse,

    /**
     * The PublicapiSubmitRequest model constructor.
     * @property {module:model/PublicapiSubmitRequest}
     */
    PublicapiSubmitRequest,

    /**
     * The PublicapiSubmitResponse model constructor.
     * @property {module:model/PublicapiSubmitResponse}
     */
    PublicapiSubmitResponse,

    /**
     * The PublicapiVersionRequest model constructor.
     * @property {module:model/PublicapiVersionRequest}
     */
    PublicapiVersionRequest,

    /**
     * The PublicapiVersionResponse model constructor.
     * @property {module:model/PublicapiVersionResponse}
     */
    PublicapiVersionResponse,

    /**
     * The RequesternodeActiveJob model constructor.
     * @property {module:model/RequesternodeActiveJob}
     */
    RequesternodeActiveJob,

    /**
     * The TypesFreeSpace model constructor.
     * @property {module:model/TypesFreeSpace}
     */
    TypesFreeSpace,

    /**
     * The TypesHealthInfo model constructor.
     * @property {module:model/TypesHealthInfo}
     */
    TypesHealthInfo,

    /**
     * The TypesMountStatus model constructor.
     * @property {module:model/TypesMountStatus}
     */
    TypesMountStatus,

    /**
    * The HealthApi service constructor.
    * @property {module:api/HealthApi}
    */
    HealthApi,

    /**
    * The JobApi service constructor.
    * @property {module:api/JobApi}
    */
    JobApi,

    /**
    * The MiscApi service constructor.
    * @property {module:api/MiscApi}
    */
    MiscApi
};
