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

import io.swagger.server.models.ModelStorageSpec

/**
 *  * @param command optional program specified on commandline, like python -c \"print(1+1)\" * @param deterministicExecution must this job be run in a deterministic context? * @param jobContext  * @param language e.g. python * @param languageVersion e.g. 3.8 * @param programPath optional program path relative to the context dir. one of Command or ProgramPath must be specified * @param requirementsPath optional requirements.txt (or equivalent) path relative to the context dir*/
data class ModelJobSpecLanguage (    /* optional program specified on commandline, like python -c \"print(1+1)\" */    val command: kotlin.String? = null,    /* must this job be run in a deterministic context? */    val deterministicExecution: kotlin.Boolean? = null,    val jobContext: ModelStorageSpec? = null,    /* e.g. python */    val language: kotlin.String? = null,    /* e.g. 3.8 */    val languageVersion: kotlin.String? = null,    /* optional program path relative to the context dir. one of Command or ProgramPath must be specified */    val programPath: kotlin.String? = null,    /* optional requirements.txt (or equivalent) path relative to the context dir */    val requirementsPath: kotlin.String? = null
) {
}
