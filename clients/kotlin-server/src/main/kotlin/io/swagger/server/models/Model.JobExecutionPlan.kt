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
*/package io.swagger.server.models


/**
 *  * @param shardsTotal how many shards are there in total for this job we are expecting this number x concurrency total JobShardState objects for this job*/
data class ModelJobExecutionPlan (    /* how many shards are there in total for this job we are expecting this number x concurrency total JobShardState objects for this job */    val shardsTotal: kotlin.Int? = null
) {
}
