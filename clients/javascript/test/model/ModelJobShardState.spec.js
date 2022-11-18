/*
 * Bacalhau API
 * This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: team@bacalhau.org
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 3.0.35
 *
 * Do not edit the class manually.
 *
 */
(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.BacalhauClient);
  }
}(this, function(expect, BacalhauClient) {
  'use strict';

  var instance;

  describe('(package)', function() {
    describe('ModelJobShardState', function() {
      beforeEach(function() {
        instance = new BacalhauClient.ModelJobShardState();
      });

      it('should create an instance of ModelJobShardState', function() {
        // TODO: update the code to test ModelJobShardState
        expect(instance).to.be.a(BacalhauClient.ModelJobShardState);
      });

      it('should have the property nodeId (base name: "NodeId")', function() {
        // TODO: update the code to test the property nodeId
        expect(instance).to.have.property('nodeId');
        // expect(instance.nodeId).to.be(expectedValueLiteral);
      });

      it('should have the property publishedResults (base name: "PublishedResults")', function() {
        // TODO: update the code to test the property publishedResults
        expect(instance).to.have.property('publishedResults');
        // expect(instance.publishedResults).to.be(expectedValueLiteral);
      });

      it('should have the property runOutput (base name: "RunOutput")', function() {
        // TODO: update the code to test the property runOutput
        expect(instance).to.have.property('runOutput');
        // expect(instance.runOutput).to.be(expectedValueLiteral);
      });

      it('should have the property shardIndex (base name: "ShardIndex")', function() {
        // TODO: update the code to test the property shardIndex
        expect(instance).to.have.property('shardIndex');
        // expect(instance.shardIndex).to.be(expectedValueLiteral);
      });

      it('should have the property state (base name: "State")', function() {
        // TODO: update the code to test the property state
        expect(instance).to.have.property('state');
        // expect(instance.state).to.be(expectedValueLiteral);
      });

      it('should have the property status (base name: "Status")', function() {
        // TODO: update the code to test the property status
        expect(instance).to.have.property('status');
        // expect(instance.status).to.be(expectedValueLiteral);
      });

      it('should have the property verificationProposal (base name: "VerificationProposal")', function() {
        // TODO: update the code to test the property verificationProposal
        expect(instance).to.have.property('verificationProposal');
        // expect(instance.verificationProposal).to.be(expectedValueLiteral);
      });

      it('should have the property verificationResult (base name: "VerificationResult")', function() {
        // TODO: update the code to test the property verificationResult
        expect(instance).to.have.property('verificationResult');
        // expect(instance.verificationResult).to.be(expectedValueLiteral);
      });

    });
  });

}));
