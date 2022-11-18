//
// ModelSpec.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct ModelSpec: Codable {

    /** Annotations on the job - could be user or machine assigned */
    public var annotations: [String]?
    /** Input volumes that will not be sharded for example to upload code into a base image every shard will get the full range of context volumes */
    public var contexts: [ModelStorageSpec]?
    /** Do not track specified by the client */
    public var doNotTrack: Bool?
    public var docker: ModelJobSpecDocker?
    /** e.g. docker or language */
    public var engine: Int?
    public var language: ModelJobSpecLanguage?
    /** there can be multiple publishers for the job */
    public var publisher: Int?
    public var resources: ModelResourceUsageConfig?
    public var sharding: ModelJobShardingConfig?
    /** How long a job can run in seconds before it is killed. This includes the time required to run, verify and publish results */
    public var timeout: Decimal?
    public var verifier: Int?
    public var wasm: ModelJobSpecWasm?
    /** the data volumes we will read in the job for example \&quot;read this ipfs cid\&quot; TODO: #667 Replace with \&quot;Inputs\&quot;, \&quot;Outputs\&quot; (note the caps) for yaml/json when we update the n.js file */
    public var inputs: [ModelStorageSpec]?
    /** the data volumes we will write in the job for example \&quot;write the results to ipfs\&quot; */
    public var outputs: [ModelStorageSpec]?

    public init(annotations: [String]? = nil, contexts: [ModelStorageSpec]? = nil, doNotTrack: Bool? = nil, docker: ModelJobSpecDocker? = nil, engine: Int? = nil, language: ModelJobSpecLanguage? = nil, publisher: Int? = nil, resources: ModelResourceUsageConfig? = nil, sharding: ModelJobShardingConfig? = nil, timeout: Decimal? = nil, verifier: Int? = nil, wasm: ModelJobSpecWasm? = nil, inputs: [ModelStorageSpec]? = nil, outputs: [ModelStorageSpec]? = nil) {
        self.annotations = annotations
        self.contexts = contexts
        self.doNotTrack = doNotTrack
        self.docker = docker
        self.engine = engine
        self.language = language
        self.publisher = publisher
        self.resources = resources
        self.sharding = sharding
        self.timeout = timeout
        self.verifier = verifier
        self.wasm = wasm
        self.inputs = inputs
        self.outputs = outputs
    }

    public enum CodingKeys: String, CodingKey { 
        case annotations = "Annotations"
        case contexts = "Contexts"
        case doNotTrack = "DoNotTrack"
        case docker = "Docker"
        case engine = "Engine"
        case language = "Language"
        case publisher = "Publisher"
        case resources = "Resources"
        case sharding = "Sharding"
        case timeout = "Timeout"
        case verifier = "Verifier"
        case wasm = "Wasm"
        case inputs
        case outputs
    }

}
