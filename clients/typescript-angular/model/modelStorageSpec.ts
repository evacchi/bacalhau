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

export interface ModelStorageSpec { 
    /**
     * The unique ID of the data, where it makes sense (for example, in an IPFS storage spec this will be the data's CID). NOTE: The below is capitalized to match IPFS & IPLD (even though it's out of golang fmt)
     */
    CID?: string;
    /**
     * Additional properties specific to each driver
     */
    metadata?: { [key: string]: string; };
    /**
     * Name of the spec's data, for reference.
     */
    name?: string;
    /**
     * StorageSource is the abstract source of the data. E.g. a storage source might be a URL download, but doesn't specify how the execution engine does the download or what it will do with the downloaded data.
     */
    storageSource?: number;
    /**
     * Source URL of the data
     */
    URL?: string;
    /**
     * The path that the spec's data should be mounted on, where it makes sense (for example, in a Docker storage spec this will be a filesystem path). TODO: #668 Replace with \"Path\" (note the caps) for yaml/json when we update the n.js file
     */
    path?: string;
}