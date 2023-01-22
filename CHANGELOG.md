# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added 

 - Validator: An abstract base class for all validators.
 - TrueValidator: A validator that is always true.
 - FalseValidator: A validator that is always false.
 - AggregateValidator: An abstract base class for validators that draw input from multiple validators.
 - AllValidator: An aggregate validator that is only true when all input validators are true.
 - AnyValidator: An aggregate validator that is true when any of its input validators are true.
 - InverseValidator: A validator that inverts the output of another validator.
 - PassthroughValidator: A validator that returns based on a public variable.
 - DelayedValidator: A validator that returns the result of an input validator but delayed.
 - RaycastValidator: A validator that returns true when a physics raycast hits something.
 - TouchValidator: A validator that return true while something is touching a collider or rigidbody on the same gameobject.
