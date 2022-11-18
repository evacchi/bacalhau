# Bacalhau API
#
# This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.
#
# OpenAPI spec version: 1.0.0
# Contact: team@bacalhau.org
# Generated by: https://github.com/swagger-api/swagger-codegen.git

#' PublicapiListResponse Class
#'
#' @field jobs 
#'
#' @importFrom R6 R6Class
#' @importFrom jsonlite fromJSON toJSON
#' @export
PublicapiListResponse <- R6::R6Class(
  'PublicapiListResponse',
  public = list(
    `jobs` = NULL,
    initialize = function(`jobs`){
      if (!missing(`jobs`)) {
        stopifnot(is.list(`jobs`), length(`jobs`) != 0)
        lapply(`jobs`, function(x) stopifnot(R6::is.R6(x)))
        self$`jobs` <- `jobs`
      }
    },
    toJSON = function() {
      PublicapiListResponseObject <- list()
      if (!is.null(self$`jobs`)) {
        PublicapiListResponseObject[['jobs']] <- lapply(self$`jobs`, function(x) x$toJSON())
      }

      PublicapiListResponseObject
    },
    fromJSON = function(PublicapiListResponseJson) {
      PublicapiListResponseObject <- jsonlite::fromJSON(PublicapiListResponseJson)
      if (!is.null(PublicapiListResponseObject$`jobs`)) {
        self$`jobs` <- lapply(PublicapiListResponseObject$`jobs`, function(x) {
          jobsObject <- ModelJob$new()
          jobsObject$fromJSON(jsonlite::toJSON(x, auto_unbox = TRUE))
          jobsObject
        })
      }
    },
    toJSONString = function() {
       sprintf(
        '{
           "jobs": [%s]
        }',
        lapply(self$`jobs`, function(x) paste(x$toJSON(), sep=","))
      )
    },
    fromJSONString = function(PublicapiListResponseJson) {
      PublicapiListResponseObject <- jsonlite::fromJSON(PublicapiListResponseJson)
      self$`jobs` <- lapply(PublicapiListResponseObject$`jobs`, function(x) ModelJob$new()$fromJSON(jsonlite::toJSON(x, auto_unbox = TRUE)))
    }
  )
)
