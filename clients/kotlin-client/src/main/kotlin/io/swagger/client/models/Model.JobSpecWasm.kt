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
package io.swagger.client.models

import io.swagger.client.models.ModelStorageSpec

/**
 * 
 * @param entryPoint The name of the function in the EntryModule to call to run the job. For WASI jobs, this will always be `_start`, but jobs can choose to call other WASM functions instead. The EntryPoint must be a zero-parameter zero-result function.
 * @param environmentVariables The variables available in the environment of the running program.
 * @param importModules TODO #880: Other WASM modules whose exports will be available as imports to the EntryModule.
 * @param parameters The arguments supplied to the program (i.e. as ARGV).
 */
data class ModelJobSpecWasm (

    /* The name of the function in the EntryModule to call to run the job. For WASI jobs, this will always be `_start`, but jobs can choose to call other WASM functions instead. The EntryPoint must be a zero-parameter zero-result function. */
    val entryPoint: kotlin.String? = null,
    /* The variables available in the environment of the running program. */
    val environmentVariables: kotlin.collections.Map<kotlin.String, kotlin.String>? = null,
    /* TODO #880: Other WASM modules whose exports will be available as imports to the EntryModule. */
    val importModules: kotlin.Array<ModelStorageSpec>? = null,
    /* The arguments supplied to the program (i.e. as ARGV). */
    val parameters: kotlin.Array<kotlin.String>? = null
) {
}