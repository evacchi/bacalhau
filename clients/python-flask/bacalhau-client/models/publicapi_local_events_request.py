# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from bacalhau-client.models.base_model_ import Model
from bacalhau-client import util


class PublicapiLocalEventsRequest(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, client_id: str=None, job_id: str=None):  # noqa: E501
        """PublicapiLocalEventsRequest - a model defined in Swagger

        :param client_id: The client_id of this PublicapiLocalEventsRequest.  # noqa: E501
        :type client_id: str
        :param job_id: The job_id of this PublicapiLocalEventsRequest.  # noqa: E501
        :type job_id: str
        """
        self.swagger_types = {
            'client_id': str,
            'job_id': str
        }

        self.attribute_map = {
            'client_id': 'client_id',
            'job_id': 'job_id'
        }
        self._client_id = client_id
        self._job_id = job_id

    @classmethod
    def from_dict(cls, dikt) -> 'PublicapiLocalEventsRequest':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The publicapi.localEventsRequest of this PublicapiLocalEventsRequest.  # noqa: E501
        :rtype: PublicapiLocalEventsRequest
        """
        return util.deserialize_model(dikt, cls)

    @property
    def client_id(self) -> str:
        """Gets the client_id of this PublicapiLocalEventsRequest.


        :return: The client_id of this PublicapiLocalEventsRequest.
        :rtype: str
        """
        return self._client_id

    @client_id.setter
    def client_id(self, client_id: str):
        """Sets the client_id of this PublicapiLocalEventsRequest.


        :param client_id: The client_id of this PublicapiLocalEventsRequest.
        :type client_id: str
        """

        self._client_id = client_id

    @property
    def job_id(self) -> str:
        """Gets the job_id of this PublicapiLocalEventsRequest.


        :return: The job_id of this PublicapiLocalEventsRequest.
        :rtype: str
        """
        return self._job_id

    @job_id.setter
    def job_id(self, job_id: str):
        """Sets the job_id of this PublicapiLocalEventsRequest.


        :param job_id: The job_id of this PublicapiLocalEventsRequest.
        :type job_id: str
        """

        self._job_id = job_id
