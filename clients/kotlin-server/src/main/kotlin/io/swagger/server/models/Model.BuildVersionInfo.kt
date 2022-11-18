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
 *  * @param builddate  * @param gitcommit  * @param gitversion  * @param goarch  * @param goos  * @param major  * @param minor */
data class ModelBuildVersionInfo (    val builddate: kotlin.String? = null,    val gitcommit: kotlin.String? = null,    val gitversion: kotlin.String? = null,    val goarch: kotlin.String? = null,    val goos: kotlin.String? = null,    val major: kotlin.String? = null,    val minor: kotlin.String? = null
) {
}
