# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from bacalhau-client.models.base_model_ import Model
from bacalhau-client import util


class ModelJobSpecDocker(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, entrypoint: List[str]=None, environment_variables: List[str]=None, image: str=None, working_directory: str=None):  # noqa: E501
        """ModelJobSpecDocker - a model defined in Swagger

        :param entrypoint: The entrypoint of this ModelJobSpecDocker.  # noqa: E501
        :type entrypoint: List[str]
        :param environment_variables: The environment_variables of this ModelJobSpecDocker.  # noqa: E501
        :type environment_variables: List[str]
        :param image: The image of this ModelJobSpecDocker.  # noqa: E501
        :type image: str
        :param working_directory: The working_directory of this ModelJobSpecDocker.  # noqa: E501
        :type working_directory: str
        """
        self.swagger_types = {
            'entrypoint': List[str],
            'environment_variables': List[str],
            'image': str,
            'working_directory': str
        }

        self.attribute_map = {
            'entrypoint': 'Entrypoint',
            'environment_variables': 'EnvironmentVariables',
            'image': 'Image',
            'working_directory': 'WorkingDirectory'
        }
        self._entrypoint = entrypoint
        self._environment_variables = environment_variables
        self._image = image
        self._working_directory = working_directory

    @classmethod
    def from_dict(cls, dikt) -> 'ModelJobSpecDocker':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The model.JobSpecDocker of this ModelJobSpecDocker.  # noqa: E501
        :rtype: ModelJobSpecDocker
        """
        return util.deserialize_model(dikt, cls)

    @property
    def entrypoint(self) -> List[str]:
        """Gets the entrypoint of this ModelJobSpecDocker.

        optionally override the default entrypoint  # noqa: E501

        :return: The entrypoint of this ModelJobSpecDocker.
        :rtype: List[str]
        """
        return self._entrypoint

    @entrypoint.setter
    def entrypoint(self, entrypoint: List[str]):
        """Sets the entrypoint of this ModelJobSpecDocker.

        optionally override the default entrypoint  # noqa: E501

        :param entrypoint: The entrypoint of this ModelJobSpecDocker.
        :type entrypoint: List[str]
        """

        self._entrypoint = entrypoint

    @property
    def environment_variables(self) -> List[str]:
        """Gets the environment_variables of this ModelJobSpecDocker.

        a map of env to run the container with  # noqa: E501

        :return: The environment_variables of this ModelJobSpecDocker.
        :rtype: List[str]
        """
        return self._environment_variables

    @environment_variables.setter
    def environment_variables(self, environment_variables: List[str]):
        """Sets the environment_variables of this ModelJobSpecDocker.

        a map of env to run the container with  # noqa: E501

        :param environment_variables: The environment_variables of this ModelJobSpecDocker.
        :type environment_variables: List[str]
        """

        self._environment_variables = environment_variables

    @property
    def image(self) -> str:
        """Gets the image of this ModelJobSpecDocker.

        this should be pullable by docker  # noqa: E501

        :return: The image of this ModelJobSpecDocker.
        :rtype: str
        """
        return self._image

    @image.setter
    def image(self, image: str):
        """Sets the image of this ModelJobSpecDocker.

        this should be pullable by docker  # noqa: E501

        :param image: The image of this ModelJobSpecDocker.
        :type image: str
        """

        self._image = image

    @property
    def working_directory(self) -> str:
        """Gets the working_directory of this ModelJobSpecDocker.

        working directory inside the container  # noqa: E501

        :return: The working_directory of this ModelJobSpecDocker.
        :rtype: str
        """
        return self._working_directory

    @working_directory.setter
    def working_directory(self, working_directory: str):
        """Sets the working_directory of this ModelJobSpecDocker.

        working directory inside the container  # noqa: E501

        :param working_directory: The working_directory of this ModelJobSpecDocker.
        :type working_directory: str
        """

        self._working_directory = working_directory
