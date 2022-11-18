# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from bacalhau-client.models.base_model_ import Model
from bacalhau-client.models.types_mount_status import TypesMountStatus  # noqa: F401,E501
from bacalhau-client import util


class TypesFreeSpace(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, ipfs_mount: TypesMountStatus=None, root: TypesMountStatus=None, tmp: TypesMountStatus=None):  # noqa: E501
        """TypesFreeSpace - a model defined in Swagger

        :param ipfs_mount: The ipfs_mount of this TypesFreeSpace.  # noqa: E501
        :type ipfs_mount: TypesMountStatus
        :param root: The root of this TypesFreeSpace.  # noqa: E501
        :type root: TypesMountStatus
        :param tmp: The tmp of this TypesFreeSpace.  # noqa: E501
        :type tmp: TypesMountStatus
        """
        self.swagger_types = {
            'ipfs_mount': TypesMountStatus,
            'root': TypesMountStatus,
            'tmp': TypesMountStatus
        }

        self.attribute_map = {
            'ipfs_mount': 'IPFSMount',
            'root': 'root',
            'tmp': 'tmp'
        }
        self._ipfs_mount = ipfs_mount
        self._root = root
        self._tmp = tmp

    @classmethod
    def from_dict(cls, dikt) -> 'TypesFreeSpace':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The types.FreeSpace of this TypesFreeSpace.  # noqa: E501
        :rtype: TypesFreeSpace
        """
        return util.deserialize_model(dikt, cls)

    @property
    def ipfs_mount(self) -> TypesMountStatus:
        """Gets the ipfs_mount of this TypesFreeSpace.


        :return: The ipfs_mount of this TypesFreeSpace.
        :rtype: TypesMountStatus
        """
        return self._ipfs_mount

    @ipfs_mount.setter
    def ipfs_mount(self, ipfs_mount: TypesMountStatus):
        """Sets the ipfs_mount of this TypesFreeSpace.


        :param ipfs_mount: The ipfs_mount of this TypesFreeSpace.
        :type ipfs_mount: TypesMountStatus
        """

        self._ipfs_mount = ipfs_mount

    @property
    def root(self) -> TypesMountStatus:
        """Gets the root of this TypesFreeSpace.


        :return: The root of this TypesFreeSpace.
        :rtype: TypesMountStatus
        """
        return self._root

    @root.setter
    def root(self, root: TypesMountStatus):
        """Sets the root of this TypesFreeSpace.


        :param root: The root of this TypesFreeSpace.
        :type root: TypesMountStatus
        """

        self._root = root

    @property
    def tmp(self) -> TypesMountStatus:
        """Gets the tmp of this TypesFreeSpace.


        :return: The tmp of this TypesFreeSpace.
        :rtype: TypesMountStatus
        """
        return self._tmp

    @tmp.setter
    def tmp(self, tmp: TypesMountStatus):
        """Sets the tmp of this TypesFreeSpace.


        :param tmp: The tmp of this TypesFreeSpace.
        :type tmp: TypesMountStatus
        """

        self._tmp = tmp
