=begin
#Bacalhau API

#This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.

OpenAPI spec version: 1.0.0
Contact: team@bacalhau.org
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.35
=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::PublicapiResultsResponse
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'PublicapiResultsResponse' do
  before do
    # run before each test
    @instance = SwaggerClient::PublicapiResultsResponse.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of PublicapiResultsResponse' do
    it 'should create an instance of PublicapiResultsResponse' do
      expect(@instance).to be_instance_of(SwaggerClient::PublicapiResultsResponse)
    end
  end
  describe 'test attribute "results"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
