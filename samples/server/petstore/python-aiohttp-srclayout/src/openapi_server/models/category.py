# coding: utf-8

from datetime import date, datetime

from typing import List, Dict, Type

from openapi_server.models.base_model import Model
from openapi_server import util


class Category(Model):
    """NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).

    Do not edit the class manually.
    """

    def __init__(self, id: int=None, name: str=None):
        """Category - a model defined in OpenAPI

        :param id: The id of this Category.
        :param name: The name of this Category.
        """
        self.openapi_types = {
            'id': int,
            'name': str
        }

        self.attribute_map = {
            'id': 'id',
            'name': 'name'
        }

        self._id = id
        self._name = name

    @classmethod
    def from_dict(cls, dikt: dict) -> 'Category':
        """Returns the dict as a model

        :param dikt: A dict.
        :return: The Category of this Category.
        """
        return util.deserialize_model(dikt, cls)

    @property
    def id(self):
        """Gets the id of this Category.


        :return: The id of this Category.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this Category.


        :param id: The id of this Category.
        :type id: int
        """

        self._id = id

    @property
    def name(self):
        """Gets the name of this Category.


        :return: The name of this Category.
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this Category.


        :param name: The name of this Category.
        :type name: str
        """

        self._name = name
