# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from bacalhau-client.models.base_model_ import Model
from bacalhau-client.models.model_resource_usage_data import ModelResourceUsageData  # noqa: F401,E501
from bacalhau-client import util


class ComputenodeActiveJob(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, capacity_requirements: ModelResourceUsageData=None, shard_id: str=None, state: str=None):  # noqa: E501
        """ComputenodeActiveJob - a model defined in Swagger

        :param capacity_requirements: The capacity_requirements of this ComputenodeActiveJob.  # noqa: E501
        :type capacity_requirements: ModelResourceUsageData
        :param shard_id: The shard_id of this ComputenodeActiveJob.  # noqa: E501
        :type shard_id: str
        :param state: The state of this ComputenodeActiveJob.  # noqa: E501
        :type state: str
        """
        self.swagger_types = {
            'capacity_requirements': ModelResourceUsageData,
            'shard_id': str,
            'state': str
        }

        self.attribute_map = {
            'capacity_requirements': 'CapacityRequirements',
            'shard_id': 'ShardID',
            'state': 'State'
        }
        self._capacity_requirements = capacity_requirements
        self._shard_id = shard_id
        self._state = state

    @classmethod
    def from_dict(cls, dikt) -> 'ComputenodeActiveJob':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The computenode.ActiveJob of this ComputenodeActiveJob.  # noqa: E501
        :rtype: ComputenodeActiveJob
        """
        return util.deserialize_model(dikt, cls)

    @property
    def capacity_requirements(self) -> ModelResourceUsageData:
        """Gets the capacity_requirements of this ComputenodeActiveJob.


        :return: The capacity_requirements of this ComputenodeActiveJob.
        :rtype: ModelResourceUsageData
        """
        return self._capacity_requirements

    @capacity_requirements.setter
    def capacity_requirements(self, capacity_requirements: ModelResourceUsageData):
        """Sets the capacity_requirements of this ComputenodeActiveJob.


        :param capacity_requirements: The capacity_requirements of this ComputenodeActiveJob.
        :type capacity_requirements: ModelResourceUsageData
        """

        self._capacity_requirements = capacity_requirements

    @property
    def shard_id(self) -> str:
        """Gets the shard_id of this ComputenodeActiveJob.


        :return: The shard_id of this ComputenodeActiveJob.
        :rtype: str
        """
        return self._shard_id

    @shard_id.setter
    def shard_id(self, shard_id: str):
        """Sets the shard_id of this ComputenodeActiveJob.


        :param shard_id: The shard_id of this ComputenodeActiveJob.
        :type shard_id: str
        """

        self._shard_id = shard_id

    @property
    def state(self) -> str:
        """Gets the state of this ComputenodeActiveJob.


        :return: The state of this ComputenodeActiveJob.
        :rtype: str
        """
        return self._state

    @state.setter
    def state(self, state: str):
        """Sets the state of this ComputenodeActiveJob.


        :param state: The state of this ComputenodeActiveJob.
        :type state: str
        """

        self._state = state
