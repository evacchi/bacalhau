# coding: utf-8

"""
    Bacalhau API

    This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.  # noqa: E501

    OpenAPI spec version: 1.0.0
    Contact: team@bacalhau.org
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class ModelBuildVersionInfo(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'builddate': 'str',
        'gitcommit': 'str',
        'gitversion': 'str',
        'goarch': 'str',
        'goos': 'str',
        'major': 'str',
        'minor': 'str'
    }

    attribute_map = {
        'builddate': 'builddate',
        'gitcommit': 'gitcommit',
        'gitversion': 'gitversion',
        'goarch': 'goarch',
        'goos': 'goos',
        'major': 'major',
        'minor': 'minor'
    }

    def __init__(self, builddate=None, gitcommit=None, gitversion=None, goarch=None, goos=None, major=None, minor=None):  # noqa: E501
        """ModelBuildVersionInfo - a model defined in Swagger"""  # noqa: E501
        self._builddate = None
        self._gitcommit = None
        self._gitversion = None
        self._goarch = None
        self._goos = None
        self._major = None
        self._minor = None
        self.discriminator = None
        if builddate is not None:
            self.builddate = builddate
        if gitcommit is not None:
            self.gitcommit = gitcommit
        if gitversion is not None:
            self.gitversion = gitversion
        if goarch is not None:
            self.goarch = goarch
        if goos is not None:
            self.goos = goos
        if major is not None:
            self.major = major
        if minor is not None:
            self.minor = minor

    @property
    def builddate(self):
        """Gets the builddate of this ModelBuildVersionInfo.  # noqa: E501


        :return: The builddate of this ModelBuildVersionInfo.  # noqa: E501
        :rtype: str
        """
        return self._builddate

    @builddate.setter
    def builddate(self, builddate):
        """Sets the builddate of this ModelBuildVersionInfo.


        :param builddate: The builddate of this ModelBuildVersionInfo.  # noqa: E501
        :type: str
        """

        self._builddate = builddate

    @property
    def gitcommit(self):
        """Gets the gitcommit of this ModelBuildVersionInfo.  # noqa: E501


        :return: The gitcommit of this ModelBuildVersionInfo.  # noqa: E501
        :rtype: str
        """
        return self._gitcommit

    @gitcommit.setter
    def gitcommit(self, gitcommit):
        """Sets the gitcommit of this ModelBuildVersionInfo.


        :param gitcommit: The gitcommit of this ModelBuildVersionInfo.  # noqa: E501
        :type: str
        """

        self._gitcommit = gitcommit

    @property
    def gitversion(self):
        """Gets the gitversion of this ModelBuildVersionInfo.  # noqa: E501


        :return: The gitversion of this ModelBuildVersionInfo.  # noqa: E501
        :rtype: str
        """
        return self._gitversion

    @gitversion.setter
    def gitversion(self, gitversion):
        """Sets the gitversion of this ModelBuildVersionInfo.


        :param gitversion: The gitversion of this ModelBuildVersionInfo.  # noqa: E501
        :type: str
        """

        self._gitversion = gitversion

    @property
    def goarch(self):
        """Gets the goarch of this ModelBuildVersionInfo.  # noqa: E501


        :return: The goarch of this ModelBuildVersionInfo.  # noqa: E501
        :rtype: str
        """
        return self._goarch

    @goarch.setter
    def goarch(self, goarch):
        """Sets the goarch of this ModelBuildVersionInfo.


        :param goarch: The goarch of this ModelBuildVersionInfo.  # noqa: E501
        :type: str
        """

        self._goarch = goarch

    @property
    def goos(self):
        """Gets the goos of this ModelBuildVersionInfo.  # noqa: E501


        :return: The goos of this ModelBuildVersionInfo.  # noqa: E501
        :rtype: str
        """
        return self._goos

    @goos.setter
    def goos(self, goos):
        """Sets the goos of this ModelBuildVersionInfo.


        :param goos: The goos of this ModelBuildVersionInfo.  # noqa: E501
        :type: str
        """

        self._goos = goos

    @property
    def major(self):
        """Gets the major of this ModelBuildVersionInfo.  # noqa: E501


        :return: The major of this ModelBuildVersionInfo.  # noqa: E501
        :rtype: str
        """
        return self._major

    @major.setter
    def major(self, major):
        """Sets the major of this ModelBuildVersionInfo.


        :param major: The major of this ModelBuildVersionInfo.  # noqa: E501
        :type: str
        """

        self._major = major

    @property
    def minor(self):
        """Gets the minor of this ModelBuildVersionInfo.  # noqa: E501


        :return: The minor of this ModelBuildVersionInfo.  # noqa: E501
        :rtype: str
        """
        return self._minor

    @minor.setter
    def minor(self, minor):
        """Sets the minor of this ModelBuildVersionInfo.


        :param minor: The minor of this ModelBuildVersionInfo.  # noqa: E501
        :type: str
        """

        self._minor = minor

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(ModelBuildVersionInfo, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, ModelBuildVersionInfo):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
