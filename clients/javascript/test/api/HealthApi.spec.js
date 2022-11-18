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

  beforeEach(function() {
    instance = new BacalhauClient.HealthApi();
  });

  describe('(package)', function() {
    describe('HealthApi', function() {
      describe('apiServerdebug', function() {
        it('should call apiServerdebug successfully', function(done) {
          // TODO: uncomment apiServerdebug call and complete the assertions
          /*

          instance.apiServerdebug(function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(BacalhauClient.PublicapiDebugResponse);

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('apiServerhealthz', function() {
        it('should call apiServerhealthz successfully', function(done) {
          // TODO: uncomment apiServerhealthz call and complete the assertions
          /*

          instance.apiServerhealthz(function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(BacalhauClient.TypesHealthInfo);

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('apiServerlivez', function() {
        it('should call apiServerlivez successfully', function(done) {
          // TODO: uncomment apiServerlivez call and complete the assertions
          /*

          instance.apiServerlivez(function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(&#x27;string&#x27;);
            // expect(data).to.be(null);

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('apiServerlogz', function() {
        it('should call apiServerlogz successfully', function(done) {
          // TODO: uncomment apiServerlogz call and complete the assertions
          /*

          instance.apiServerlogz(function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(&#x27;string&#x27;);
            // expect(data).to.be(null);

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('apiServerreadyz', function() {
        it('should call apiServerreadyz successfully', function(done) {
          // TODO: uncomment apiServerreadyz call and complete the assertions
          /*

          instance.apiServerreadyz(function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(&#x27;string&#x27;);
            // expect(data).to.be(null);

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('apiServervarz', function() {
        it('should call apiServervarz successfully', function(done) {
          // TODO: uncomment apiServervarz call and complete the assertions
          /*

          instance.apiServervarz(function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            let dataCtr = data;
            expect(dataCtr).to.be.an(Array);
            expect(dataCtr).to.not.be.empty();
            for (let p in dataCtr) {
              let data = dataCtr[p];
              expect(data).to.be.a(&#x27;number&#x27;);
              // expect(data).to.be(null);
            }

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
    });
  });

}));
