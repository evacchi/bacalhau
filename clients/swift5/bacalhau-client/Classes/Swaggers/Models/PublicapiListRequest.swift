//
// PublicapiListRequest.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct PublicapiListRequest: Codable {

    public var clientId: String?
    public var _id: String?
    public var maxJobs: Int?
    public var returnAll: Bool?
    public var sortBy: String?
    public var sortReverse: Bool?

    public init(clientId: String? = nil, _id: String? = nil, maxJobs: Int? = nil, returnAll: Bool? = nil, sortBy: String? = nil, sortReverse: Bool? = nil) {
        self.clientId = clientId
        self._id = _id
        self.maxJobs = maxJobs
        self.returnAll = returnAll
        self.sortBy = sortBy
        self.sortReverse = sortReverse
    }

    public enum CodingKeys: String, CodingKey { 
        case clientId = "client_id"
        case _id = "id"
        case maxJobs = "max_jobs"
        case returnAll = "return_all"
        case sortBy = "sort_by"
        case sortReverse = "sort_reverse"
    }

}
