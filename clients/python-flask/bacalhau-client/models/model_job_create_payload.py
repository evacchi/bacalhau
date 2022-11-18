# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from bacalhau-client.models.base_model_ import Model
from bacalhau-client.models.model_job import ModelJob  # noqa: F401,E501
from bacalhau-client import util


class ModelJobCreatePayload(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, client_id: str=None, context: str=None, job: ModelJob=None):  # noqa: E501
        """ModelJobCreatePayload - a model defined in Swagger

        :param client_id: The client_id of this ModelJobCreatePayload.  # noqa: E501
        :type client_id: str
        :param context: The context of this ModelJobCreatePayload.  # noqa: E501
        :type context: str
        :param job: The job of this ModelJobCreatePayload.  # noqa: E501
        :type job: ModelJob
        """
        self.swagger_types = {
            'client_id': str,
            'context': str,
            'job': ModelJob
        }

        self.attribute_map = {
            'client_id': 'ClientID',
            'context': 'Context',
            'job': 'Job'
        }
        self._client_id = client_id
        self._context = context
        self._job = job

    @classmethod
    def from_dict(cls, dikt) -> 'ModelJobCreatePayload':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The model.JobCreatePayload of this ModelJobCreatePayload.  # noqa: E501
        :rtype: ModelJobCreatePayload
        """
        return util.deserialize_model(dikt, cls)

    @property
    def client_id(self) -> str:
        """Gets the client_id of this ModelJobCreatePayload.

        the id of the client that is submitting the job  # noqa: E501

        :return: The client_id of this ModelJobCreatePayload.
        :rtype: str
        """
        return self._client_id

    @client_id.setter
    def client_id(self, client_id: str):
        """Sets the client_id of this ModelJobCreatePayload.

        the id of the client that is submitting the job  # noqa: E501

        :param client_id: The client_id of this ModelJobCreatePayload.
        :type client_id: str
        """
        if client_id is None:
            raise ValueError("Invalid value for `client_id`, must not be `None`")  # noqa: E501

        self._client_id = client_id

    @property
    def context(self) -> str:
        """Gets the context of this ModelJobCreatePayload.

        Optional base64-encoded tar file that will be pinned to IPFS and mounted as storage for the job. Not part of the spec so we don't flood the transport layer with it (potentially very large).  # noqa: E501

        :return: The context of this ModelJobCreatePayload.
        :rtype: str
        """
        return self._context

    @context.setter
    def context(self, context: str):
        """Sets the context of this ModelJobCreatePayload.

        Optional base64-encoded tar file that will be pinned to IPFS and mounted as storage for the job. Not part of the spec so we don't flood the transport layer with it (potentially very large).  # noqa: E501

        :param context: The context of this ModelJobCreatePayload.
        :type context: str
        """

        self._context = context

    @property
    def job(self) -> ModelJob:
        """Gets the job of this ModelJobCreatePayload.


        :return: The job of this ModelJobCreatePayload.
        :rtype: ModelJob
        """
        return self._job

    @job.setter
    def job(self, job: ModelJob):
        """Sets the job of this ModelJobCreatePayload.


        :param job: The job of this ModelJobCreatePayload.
        :type job: ModelJob
        """
        if job is None:
            raise ValueError("Invalid value for `job`, must not be `None`")  # noqa: E501

        self._job = job
