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
 *  * @param cPU https://github.com/BTBurke/k8sresource string * @param disk  * @param gPU unsigned integer string * @param memory github.com/c2h5oh/datasize string*/
data class ModelResourceUsageConfig (    /* https://github.com/BTBurke/k8sresource string */    val cPU: kotlin.String? = null,    val disk: kotlin.String? = null,    /* unsigned integer string */    val gPU: kotlin.String? = null,    /* github.com/c2h5oh/datasize string */    val memory: kotlin.String? = null
) {
}
