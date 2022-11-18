# coding: utf-8

"""
    Bacalhau API

    This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.  # noqa: E501

    OpenAPI spec version: 1.0.0
    Contact: team@bacalhau.org
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import bacalhau_client
from bacalhau_client.api.health_api import HealthApi  # noqa: E501
from bacalhau_client.rest import ApiException


class TestHealthApi(unittest.TestCase):
    """HealthApi unit test stubs"""

    def setUp(self):
        self.api = HealthApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_api_serverdebug(self):
        """Test case for api_serverdebug

        Returns debug information on what the current node is doing.  # noqa: E501
        """
        pass

    def test_api_serverhealthz(self):
        """Test case for api_serverhealthz

        """
        pass

    def test_api_serverlivez(self):
        """Test case for api_serverlivez

        """
        pass

    def test_api_serverlogz(self):
        """Test case for api_serverlogz

        """
        pass

    def test_api_serverreadyz(self):
        """Test case for api_serverreadyz

        """
        pass

    def test_api_servervarz(self):
        """Test case for api_servervarz

        """
        pass


if __name__ == '__main__':
    unittest.main()
