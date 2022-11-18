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
 *  * @param exitCode exit code of the run. * @param runnerError Runner error * @param stderr stderr of the run. * @param stderrtruncated bool describing if stderr was truncated * @param stdout stdout of the run. Yaml provided for `describe` output * @param stdouttruncated bool describing if stdout was truncated*/
data class ModelRunCommandResult (    /* exit code of the run. */    val exitCode: kotlin.Int? = null,    /* Runner error */    val runnerError: kotlin.String? = null,    /* stderr of the run. */    val stderr: kotlin.String? = null,    /* bool describing if stderr was truncated */    val stderrtruncated: kotlin.Boolean? = null,    /* stdout of the run. Yaml provided for `describe` output */    val stdout: kotlin.String? = null,    /* bool describing if stdout was truncated */    val stdouttruncated: kotlin.Boolean? = null
) {
}
