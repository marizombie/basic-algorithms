tree = {
    10 : [8, 13],
    8 : [3, 9],
    13 : [15],
    3 : [],
    9 : [],
    15 : []
}


visited, queue = [], []


def bfs(root_node, goal):
    visited.append(root_node)
    queue.append(root_node)

    while queue:
        node = queue.pop(0)
        print(node, end=' ')
        if node == goal:            
            print('\nFound goal')
            return node

        for neighbor in tree[node]:
            if neighbor not in visited:
                visited.append(neighbor)
                queue.append(neighbor)

bfs(root_node=10, goal=1)
