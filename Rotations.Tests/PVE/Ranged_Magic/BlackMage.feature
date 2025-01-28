Feature: Black Mage

Scenario: Neutral stance not opener

    Given that I am not moving

    Given that I have no astral fire or umbral ice

    Given I have more than 800 mana

    When I want to pick a GCD

    Then the choice is BlizzardIII