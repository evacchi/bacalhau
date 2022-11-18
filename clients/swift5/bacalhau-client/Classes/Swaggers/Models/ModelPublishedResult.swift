//
// ModelPublishedResult.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct ModelPublishedResult: Codable {

    public var data: ModelStorageSpec?
    public var nodeID: String?
    public var shardIndex: Int?

    public init(data: ModelStorageSpec? = nil, nodeID: String? = nil, shardIndex: Int? = nil) {
        self.data = data
        self.nodeID = nodeID
        self.shardIndex = shardIndex
    }

    public enum CodingKeys: String, CodingKey { 
        case data = "Data"
        case nodeID = "NodeID"
        case shardIndex = "ShardIndex"
    }

}
