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
    describe('PublicapiLocalEventsResponse', function() {
      beforeEach(function() {
        instance = new BacalhauClient.PublicapiLocalEventsResponse();
      });

      it('should create an instance of PublicapiLocalEventsResponse', function() {
        // TODO: update the code to test PublicapiLocalEventsResponse
        expect(instance).to.be.a(BacalhauClient.PublicapiLocalEventsResponse);
      });

      it('should have the property localEvents (base name: "localEvents")', function() {
        // TODO: update the code to test the property localEvents
        expect(instance).to.have.property('localEvents');
        // expect(instance.localEvents).to.be(expectedValueLiteral);
      });

    });
  });

}));
