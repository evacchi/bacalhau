# Bacalhau API
#
# This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.
#
# OpenAPI spec version: 1.0.0
# Contact: team@bacalhau.org
# Generated by: https://github.com/swagger-api/swagger-codegen.git

#' ModelDeal Class
#'
#' @field Concurrency 
#' @field Confidence 
#' @field MinBids 
#'
#' @importFrom R6 R6Class
#' @importFrom jsonlite fromJSON toJSON
#' @export
ModelDeal <- R6::R6Class(
  'ModelDeal',
  public = list(
    `Concurrency` = NULL,
    `Confidence` = NULL,
    `MinBids` = NULL,
    initialize = function(`Concurrency`, `Confidence`, `MinBids`){
      if (!missing(`Concurrency`)) {
        stopifnot(is.numeric(`Concurrency`), length(`Concurrency`) == 1)
        self$`Concurrency` <- `Concurrency`
      }
      if (!missing(`Confidence`)) {
        stopifnot(is.numeric(`Confidence`), length(`Confidence`) == 1)
        self$`Confidence` <- `Confidence`
      }
      if (!missing(`MinBids`)) {
        stopifnot(is.numeric(`MinBids`), length(`MinBids`) == 1)
        self$`MinBids` <- `MinBids`
      }
    },
    toJSON = function() {
      ModelDealObject <- list()
      if (!is.null(self$`Concurrency`)) {
        ModelDealObject[['Concurrency']] <- self$`Concurrency`
      }
      if (!is.null(self$`Confidence`)) {
        ModelDealObject[['Confidence']] <- self$`Confidence`
      }
      if (!is.null(self$`MinBids`)) {
        ModelDealObject[['MinBids']] <- self$`MinBids`
      }

      ModelDealObject
    },
    fromJSON = function(ModelDealJson) {
      ModelDealObject <- jsonlite::fromJSON(ModelDealJson)
      if (!is.null(ModelDealObject$`Concurrency`)) {
        self$`Concurrency` <- ModelDealObject$`Concurrency`
      }
      if (!is.null(ModelDealObject$`Confidence`)) {
        self$`Confidence` <- ModelDealObject$`Confidence`
      }
      if (!is.null(ModelDealObject$`MinBids`)) {
        self$`MinBids` <- ModelDealObject$`MinBids`
      }
    },
    toJSONString = function() {
       sprintf(
        '{
           "Concurrency": %d,
           "Confidence": %d,
           "MinBids": %d
        }',
        self$`Concurrency`,
        self$`Confidence`,
        self$`MinBids`
      )
    },
    fromJSONString = function(ModelDealJson) {
      ModelDealObject <- jsonlite::fromJSON(ModelDealJson)
      self$`Concurrency` <- ModelDealObject$`Concurrency`
      self$`Confidence` <- ModelDealObject$`Confidence`
      self$`MinBids` <- ModelDealObject$`MinBids`
    }
  )
)
