# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from bacalhau-client.models.base_model_ import Model
from bacalhau-client.models.types_free_space import TypesFreeSpace  # noqa: F401,E501
from bacalhau-client import util


class TypesHealthInfo(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, free_space: TypesFreeSpace=None):  # noqa: E501
        """TypesHealthInfo - a model defined in Swagger

        :param free_space: The free_space of this TypesHealthInfo.  # noqa: E501
        :type free_space: TypesFreeSpace
        """
        self.swagger_types = {
            'free_space': TypesFreeSpace
        }

        self.attribute_map = {
            'free_space': 'FreeSpace'
        }
        self._free_space = free_space

    @classmethod
    def from_dict(cls, dikt) -> 'TypesHealthInfo':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The types.HealthInfo of this TypesHealthInfo.  # noqa: E501
        :rtype: TypesHealthInfo
        """
        return util.deserialize_model(dikt, cls)

    @property
    def free_space(self) -> TypesFreeSpace:
        """Gets the free_space of this TypesHealthInfo.


        :return: The free_space of this TypesHealthInfo.
        :rtype: TypesFreeSpace
        """
        return self._free_space

    @free_space.setter
    def free_space(self, free_space: TypesFreeSpace):
        """Sets the free_space of this TypesHealthInfo.


        :param free_space: The free_space of this TypesHealthInfo.
        :type free_space: TypesFreeSpace
        """

        self._free_space = free_space
