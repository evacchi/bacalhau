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
    describe('ModelJobLocalEvent', function() {
      beforeEach(function() {
        instance = new BacalhauClient.ModelJobLocalEvent();
      });

      it('should create an instance of ModelJobLocalEvent', function() {
        // TODO: update the code to test ModelJobLocalEvent
        expect(instance).to.be.a(BacalhauClient.ModelJobLocalEvent);
      });

      it('should have the property eventName (base name: "EventName")', function() {
        // TODO: update the code to test the property eventName
        expect(instance).to.have.property('eventName');
        // expect(instance.eventName).to.be(expectedValueLiteral);
      });

      it('should have the property jobID (base name: "JobID")', function() {
        // TODO: update the code to test the property jobID
        expect(instance).to.have.property('jobID');
        // expect(instance.jobID).to.be(expectedValueLiteral);
      });

      it('should have the property shardIndex (base name: "ShardIndex")', function() {
        // TODO: update the code to test the property shardIndex
        expect(instance).to.have.property('shardIndex');
        // expect(instance.shardIndex).to.be(expectedValueLiteral);
      });

      it('should have the property targetNodeID (base name: "TargetNodeID")', function() {
        // TODO: update the code to test the property targetNodeID
        expect(instance).to.have.property('targetNodeID');
        // expect(instance.targetNodeID).to.be(expectedValueLiteral);
      });

    });
  });

}));
