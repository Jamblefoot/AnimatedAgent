# AnimatedAgent
A solution for syncing an Animator with a NavMeshAgent that doesn't require a strafe set

Unity provides a solution for syncing an animator and a NavMeshAgent that requires use of a strafe set. This is an alternative solution that can work with just an idle animation and a walking animation.

To set it up, there should be a "move" bool parameter on the animator that is used to transition into and out of the walking animation.

There should also be a "speed" float parameter that is set up to modify the speed of the walk animation.

You can adjust the move and turn speed on the NavMeshAgent component and it will effect the animation/turning of the character.

Hope this helps!
