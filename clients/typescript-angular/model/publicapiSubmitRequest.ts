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
import { ModelJobCreatePayload } from './modelJobCreatePayload';

export interface PublicapiSubmitRequest { 
    /**
     * The base64-encoded public key of the client:
     */
    clientPublicKey: string;
    data: ModelJobCreatePayload;
    /**
     * A base64-encoded signature of the data, signed by the client:
     */
    signature: string;
}