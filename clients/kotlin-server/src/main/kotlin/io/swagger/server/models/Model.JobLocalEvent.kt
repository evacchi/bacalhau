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
 *  * @param eventName  * @param jobID  * @param shardIndex  * @param targetNodeID */
data class ModelJobLocalEvent (    val eventName: kotlin.Int? = null,    val jobID: kotlin.String? = null,    val shardIndex: kotlin.Int? = null,    val targetNodeID: kotlin.String? = null
) {
}
