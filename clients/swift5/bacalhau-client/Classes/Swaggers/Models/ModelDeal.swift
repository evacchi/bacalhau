//
// ModelDeal.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct ModelDeal: Codable {

    /** The maximum number of concurrent compute node bids that will be accepted by the requester node on behalf of the client. */
    public var concurrency: Int?
    /** The number of nodes that must agree on a verification result this is used by the different verifiers - for example the deterministic verifier requires the winning group size to be at least this size */
    public var confidence: Int?
    /** The minimum number of bids that must be received before the Requester node will randomly accept concurrency-many of them. This allows the Requester node to get some level of guarantee that the execution of the jobs will be spread evenly across the network (assuming that this value is some large proportion of the size of the network). */
    public var minBids: Int?

    public init(concurrency: Int? = nil, confidence: Int? = nil, minBids: Int? = nil) {
        self.concurrency = concurrency
        self.confidence = confidence
        self.minBids = minBids
    }

    public enum CodingKeys: String, CodingKey { 
        case concurrency = "Concurrency"
        case confidence = "Confidence"
        case minBids = "MinBids"
    }

}
